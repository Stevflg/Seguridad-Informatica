using Dominio.DTO;
using Dominio.Entidades;
using Microsoft.VisualBasic.ApplicationServices;
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
        private Usuario User;
        public Form_Permisos(Usuario User)
        {
            InitializeComponent();
            this.User = User;
        }


        private async void Form_Permisos_Load(object sender, EventArgs e)
        {
            await Task.Run(() => { CargarUsuarios(); });
            await Task.Run(() => { CargarRoles(); });
            await Task.Run(() => { CargarDatos(); });
        }

        private async void CargarDatos()
        {
            var id = (IdUsuario > 0) ? IdUsuario : 1;
            var data = await NPermisos.GetPermisos(new Usuario { Id = IdUsuario });
            this.Invoke(new Action(() =>
            {
                DataGridViewPermiso.DataSource = data;
            }));
        }
        private async void CargarUsuarios()
        {
            try
            {

                var ListUsuario = await NPermisos.UsuariosList();
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
                    ComboBoxUsuario.AutoCompleteSource = AutoCompleteSource.ListItems;

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

                var ListRol = await NPermisos.RolesList();
                this.Invoke(new Action(() =>
                {
                    ComboBoxRol.DataSource = ListRol;
                    ComboBoxRol.ValueMember = "Id";
                    ComboBoxRol.DisplayMember = "Rol";

                    AutoCompleteStringCollection lst = new AutoCompleteStringCollection();
                    for (int i = 0; i < ListRol.Count; i++)
                    {
                        lst.Add(ListRol[i].Rol);
                    }
                    ComboBoxRol.AutoCompleteCustomSource = lst;
                    ComboBoxRol.AutoCompleteMode = AutoCompleteMode.Suggest;
                    ComboBoxRol.AutoCompleteSource = AutoCompleteSource.ListItems;

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
            var result = await NPermisos.AgregarPermiso(new RolUsuario
            {
                IdRol = IdRol,
                IdUsuario = IdUsuario,
                Activo = true,
                UsuarioRegistro = User.Id,
                FechaRegistro = DateTime.Now
            });

            this.Invoke(new Action(() =>
            {
                MessageBox.Show(result, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
            }));
        }

        private short PermisoId;
        private async void RevocarPermiso()
        {
            var result = await NPermisos.Eliminar(new PermisosDTO
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

        private void DataGridViewPermiso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                try
                {
                    if (DataGridViewPermiso.Rows[e.RowIndex].Cells[0].Value.ToString() == string.Empty)
                    {
                        MessageBox.Show("Elija una fila válida.");
                        ButtonEliminar.Enabled = false;
                    }
                    else
                    {
                        PermisoId = short.Parse(DataGridViewPermiso.Rows[e.RowIndex].Cells[0].Value.ToString());
                        ButtonEliminar.Enabled = true;
                    }
                }
                catch
                {
                    ButtonEliminar.Enabled = false;
                }
            }
            catch { }
        }
    }
}
