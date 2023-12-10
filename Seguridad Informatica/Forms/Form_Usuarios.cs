using Dominio.Entidades;
using Negocio.Procedimientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguridad_Informatica.Forms
{
    public partial class Form_Usuarios : Form
    {
        private Usuario usuario;
        private Usuario InicioSesion;
        public Form_Usuarios(Usuario InicioSesion)
        {
            InitializeComponent();
            this.InicioSesion = InicioSesion;
        }

        private async void Form_Usuarios_Load(object sender, EventArgs e)
        {
            await Task.Run(() => CargarDatos());
            LoadDatagridRoles();
            LoadRoles();
        }

        #region Metodos
        private async void CargarDatos()
        {
            var listausuarios = await NUsuarios.GetListUsuarios();
            UserId = listausuarios.First().Id;
            this.Invoke(new Action(() =>
            {
                DataGridUsuarios.DataSource = listausuarios;
                LoadDatagridRoles();
            }));
        }

        private short UserId = 0;

        private async void Eliminar()
        {
            if (UserId != 0)
            {
                usuario = new Usuario
                {
                    Id = UserId,
                    UsuarioActualiza = InicioSesion.Id,
                    FechaActualizacion = DateTime.Now
                };
                var resultado = await NUsuarios.Delete(usuario);
                this.Invoke(new Action(() =>
                {
                    MessageBox.Show(resultado, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                }));
            }
        }

        private void ClearTextBoxes()
        {
            TextBoxNombre.Clear();
            TextBoxCorreo.Clear();
            TextBoxUsername.Clear();
        }
        #endregion

        #region DataGrids
        private void DataGridViewRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DataGridViewRoles.Rows[e.RowIndex].Cells[0].Value.ToString() == string.Empty)
                {
                    ClearTextBoxes();
                    EnabledButtons(false);
                }
                else
                {
                    RolId = byte.Parse(DataGridViewRoles.Rows[e.RowIndex].Cells[0].Value.ToString());
                    EnabledButtons(true);
                }
            }
            catch
            {
                ClearTextBoxes();
                EnabledButtons(false);
            }
        }

        private void EnabledButtons(bool state)
        {
            ButtonAgregarRol.Enabled = !state;
            ButtonRevocarRol.Enabled = state;
            ButtonHabilitarRol.Enabled = state;
        }


        private void DataGridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DataGridUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString() == string.Empty)
                {
                    ClearTextBoxes();
                    MessageBox.Show("Elija una fila válida.");
                    ButtonEditar.Enabled = false;
                    ButtonEliminar.Enabled = false;
                }
                else
                {
                    UserId = short.Parse(DataGridUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString());
                    TextBoxNombre.Text = DataGridUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                    TextBoxCorreo.Text = DataGridUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                    TextBoxUsername.Text = DataGridUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                    ButtonEditar.Enabled = true;
                    ButtonEliminar.Enabled = true;
                    LoadDatagridRoles();
                }
            }
            catch
            {
                ClearTextBoxes();
                MessageBox.Show("Elija una fila válida.");
                ButtonEditar.Enabled = false;
                ButtonEliminar.Enabled = false;
            }
        }
        private async void LoadDatagridRoles()
        {
            var data = await NAsignacionRoles.UserRolList(new Usuario { Id = UserId });
            this.Invoke(new Action(() =>
            {
                DataGridViewRoles.DataSource = data;
            }));
        }
        private async void LoadRoles()
        {
            try
            {
                var ListRoles = await NAsignacionRoles.ListRole();
                this.Invoke(new Action(() =>
                {
                    ComboBoxRol.DataSource = ListRoles;
                    ComboBoxRol.ValueMember = "Id";
                    ComboBoxRol.DisplayMember = "Rol";

                    AutoCompleteStringCollection lst = new AutoCompleteStringCollection();
                    for (int i = 0; i < ListRoles.Count; i++)
                    {
                        lst.Add(ListRoles[i].Rol);
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
        private byte RolId = 0;
        private void ComboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                EnabledButtons(false);
                RolId = byte.Parse(ComboBoxRol.SelectedValue.ToString());
            }
            catch
            { }
        }
        #endregion

        #region Eventos
        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            Registrar FormRegistrar = new Registrar(InicioSesion);
            FormRegistrar.ShowDialog();
            CargarDatos();
        }

        private async void ButtonEliminar_Click(object sender, EventArgs e)
        {
            this.Invoke(new Action(() => { ButtonEliminar.Enabled = false; }));
            await Task.Run(() => { Eliminar(); });
            this.Invoke(new Action(() => { ButtonEliminar.Enabled = true; }));
        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            Editar_Usuario FormEditar = new Editar_Usuario(InicioSesion, UserId);
            FormEditar.ShowDialog();
            CargarDatos();
        }

        private async void ButtonAgregarRol_Click(object sender, EventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                ButtonAgregarRol.Enabled = false;
                ButtonRevocarRol.Enabled = false;
                ButtonHabilitarRol.Enabled = false;
            }));
            await Task.Run(() => { AgregarPermiso(); });
            this.Invoke(new Action(() =>
            {
                EnabledButtons(false);
            }));
        }

        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                ButtonAgregarRol.Enabled = false;
                ButtonRevocarRol.Enabled = false;
                ButtonHabilitarRol.Enabled = false;
            }));
            await Task.Run(() => { RevocarPermiso(); });
            this.Invoke(new Action(() =>
            {
                EnabledButtons(true);
            }));
        }

        private async void ButtonHabilitarRol_Click(object sender, EventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                ButtonAgregarRol.Enabled = false;
                ButtonRevocarRol.Enabled = false;
                ButtonHabilitarRol.Enabled = false;
            }));
            await Task.Run(() => { HabilitarPermiso(); });
            this.Invoke(new Action(() =>
            {
                EnabledButtons(true);
            }));
        }
        #endregion


        #region Metodos
        private async void AgregarPermiso()
        {
            var result = await NAsignacionRoles.AgregarRolUsuario(new RolUsuario
            {
                IdUsuario = UserId,
                IdRol = RolId,
                UsuarioRegistro = InicioSesion.Id
            });
            this.Invoke(() =>
            {
                MessageBox.Show(result, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDatagridRoles();
            });
        }

        private async void RevocarPermiso()
        {
            var result = await NAsignacionRoles.RevocarPermiso(new RolUsuario
            {
                IdUsuario = UserId,
                IdRol = RolId,
                UsuarioActualiza = InicioSesion.Id,
                FechaActualizacion = DateTime.Now
            });
            this.Invoke(() =>
            {
                MessageBox.Show(result, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDatagridRoles();
            });
        }

        private async void HabilitarPermiso()
        {
            var result = await NAsignacionRoles.HabilitarPermiso(new RolUsuario
            {
                IdUsuario = UserId,
                IdRol = RolId,
                UsuarioActualiza = InicioSesion.Id,
                FechaActualizacion = DateTime.Now
            });
            this.Invoke(() =>
            {
                MessageBox.Show(result, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDatagridRoles();
            });
        }
        #endregion
    }
}