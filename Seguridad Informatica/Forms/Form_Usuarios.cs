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
    public partial class Form_Usuarios : Form
    {
        private readonly NUsuarios Nusers;
        private Usuario usuario;
        private Usuario InicioSesion;
        public Form_Usuarios(Usuario InicioSesion)
        {
            InitializeComponent();
            Nusers = new NUsuarios();
            this.InicioSesion = InicioSesion;
        }


        private async void Form_Usuarios_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        #region Metodos
        private async void CargarDatos()
        {
            var listausuarios = await Nusers.GetListUsuarios();
            this.Invoke(new Action(() =>
            {
                DataGridUsuarios.DataSource = listausuarios;
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
                var resultado = await Nusers.Delete(usuario);
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
                }
            }
            catch { }
        }

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
    }
}
