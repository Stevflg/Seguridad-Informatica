using Dominio.DTO;
using Dominio.Entidades;
using Negocio.Procedimientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguridad_Informatica.Forms
{
    public partial class Form_Permisos : Form
    {
        private readonly NPermisos permisos;
        private Usuario User;
        public Form_Permisos(Usuario User)
        {
            InitializeComponent();
            this.permisos = new NPermisos();
            this.User = User;
        }


        private async void Form_Permisos_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarRoles();
            CargarDatos();
        }

        private async void CargarDatos()
        {
            var id = (IdUsuario > 0) ? IdUsuario : 1;
            var data = await permisos.GetPermisos(new Usuario { Id = IdUsuario });
            this.Invoke(new Action(() =>
            {
                DataGridViewPermiso.DataSource = data;
            }));
        }
        private async void CargarUsuarios()
        {
            try
            {

                var ListUsuario = await permisos.UsuariosList();
                this.Invoke(new Action(() =>
                {
                    ComboBoxUsuario.DataSource = ListUsuario;
                    ComboBoxUsuario.ValueMember = "Id";
                    ComboBoxUsuario.DisplayMember = "Nombre";

                    AutoCompleteStringCollection lst = new AutoCompleteStringCollection();
                    for (int i = 0; i < ListUsuario.Count; i++)
                    {
                        lst.Add(ListUsuario[i].Nombre);
                    }
                    ComboBoxUsuario.AutoCompleteCustomSource = lst;
                    ComboBoxUsuario.AutoCompleteMode = AutoCompleteMode.Suggest;
                    ComboBoxUsuario.AutoCompleteSource = AutoCompleteSource.CustomSource;

                }));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void CargarRoles()
        {
            try
            {

                var ListRol = await permisos.RolesList();
                this.Invoke(new Action(() =>
                {
                    ComboBoxRol.DataSource = ListRol;
                    ComboBoxRol.ValueMember = "Id";
                    ComboBoxRol.DisplayMember = "Nombre";

                    AutoCompleteStringCollection lst = new AutoCompleteStringCollection();
                    for (int i = 0; i < ListRol.Count; i++)
                    {
                        lst.Add(ListRol[i].Rol);
                    }
                    ComboBoxRol.AutoCompleteCustomSource = lst;
                    ComboBoxRol.AutoCompleteMode = AutoCompleteMode.Suggest;
                    ComboBoxRol.AutoCompleteSource = AutoCompleteSource.CustomSource;

                }));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private short IdUsuario;
        private byte IdRol;
        private void ComboBoxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                IdUsuario = short.Parse(ComboBoxUsuario.SelectedValue.ToString());
            }
            catch
            { }
        }

        private void ComboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                IdRol = byte.Parse(ComboBoxRol.SelectedValue.ToString());
            }
            catch
            { }
        }

        private async void AgregarPermiso()
        {
            var result = await permisos.AgregarPermiso(new RolUsuario
            {
                IdRol = IdRol,
                IdUsuario = IdUsuario,
                Activo = true,
                UsuarioRegistro = User.Id,
                FechaRegistro = DateTime.Now
            });

            this.Invoke(new Action(() =>
            {
                MessageBox.Show(result, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CargarDatos();
            }));
        }

        private short PermisoId;
        private async void RevocarPermiso()
        {
            var result = await permisos.Eliminar(new PermisosDTO
            {
                Id = PermisoId,
            }, new Usuario { Id = User.Id, FechaActualizacion = DateTime.Now });
            this.Invoke(new Action(() =>
            {
                MessageBox.Show(result, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CargarDatos();
            }));
        }

        private async void ButtonAgregar_Click(object sender, EventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                ButtonAgregar.Enabled = false;
                ButtonEliminar.Enabled = false;
            }));
            await Task.Run(() => { AgregarPermiso(); });
            this.Invoke(new Action(() =>
            {
                ButtonAgregar.Enabled = true;
                ButtonEliminar.Enabled = true;
            }));
        }

        private async void ButtonEliminar_Click(object sender, EventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                ButtonAgregar.Enabled = false;
                ButtonEliminar.Enabled = false;
            }));
            await Task.Run(() => { RevocarPermiso(); });
            this.Invoke(new Action(() =>
            {
                ButtonAgregar.Enabled = true;
                ButtonEliminar.Enabled = true;
            }));
        }
    }
}
