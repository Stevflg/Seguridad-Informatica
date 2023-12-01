using Dominio.Entidades;
using Negocio.Procedimientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguridad_Informatica.Forms
{
    public partial class Editar_Usuario : Form
    {
        private Usuario InicioSesion;
        private NUsuarios Nuser;
        private short Userid;
        public Editar_Usuario(Usuario InicioSesion, short Userid)
        {
            InitializeComponent();
            this.InicioSesion = InicioSesion;
            this.Userid = Userid;
            this.Nuser = new NUsuarios();
        }

        private bool ContraseñaSegura(string Contraseña)
        {
            Regex letras = new(@"[a-zA-z]");
            Regex numeros = new Regex(@"[0-9]");
            Regex caracEsp = new Regex("[!\"#\\$%&'()*+,-./:;=?@\\[\\]^_`{|}~]");
            var result = (letras.IsMatch(Contraseña) && numeros.IsMatch(Contraseña) && caracEsp.IsMatch(Contraseña) && Contraseña.Length > 9) ? true : false;
            return result;
        }


        private Usuario UsuarioEditar;
        private async void LoadUser()
        {
            var result = await Nuser.GetUsarioId(new Usuario { Id = Userid });
            this.Invoke(new Action(() =>
            {
                TextBoxNombre.Text = result.Nombre;
                TextBoxCorreo.Text = result.Correo;
                TextBoxUsername.Text = result.Login;
                this.UsuarioEditar = result;
            }));
        }

        private async void Editar_Usuario_Load(object sender, EventArgs e)
        {
            LoadUser();
        }
        private async void EditarUsuario()
        {
            if (!string.IsNullOrEmpty(TextBoxNombre.Text) && (!string.IsNullOrEmpty(TextBoxCorreo.Text)) &&
                !string.IsNullOrEmpty(TextBoxUsername.Text))
            {
                var usuarioregistro = (InicioSesion.Id > 0) ? InicioSesion.Id : 1;
                var pass = (string.IsNullOrEmpty(TextBoxContraseña.Text)) ? UsuarioEditar.Password : Encrypt.EncryptPass(TextBoxContraseña.Text);
                Usuario u = new Usuario
                {
                    Id = UsuarioEditar.Id,
                    Nombre = TextBoxNombre.Text,
                    Correo = TextBoxCorreo.Text,
                    Login = TextBoxUsername.Text,
                    Password = pass,
                    FechaActualizacion = DateTime.Now,
                    UsuarioActualiza = usuarioregistro
                };
                var result = await Nuser.Update(u);
                this.Invoke(new Action(() =>
                {
                    MessageBox.Show(result, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }));
            }
            else
            {
                MessageBox.Show("Rellene los campos vacios", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void ButtonGuardar_Click(object sender, EventArgs e)
        {
            this.Invoke(new Action(() => { ButtonGuardar.Enabled = false; }));
            if (string.IsNullOrEmpty(TextBoxContraseña.Text))
            {
                await Task.Run(() => { EditarUsuario(); });
            }
            else
            {
                if (ContraseñaSegura(TextBoxContraseña.Text))
                {
                    await Task.Run(() => { EditarUsuario(); });
                }
                else
                {
                    this.Invoke(new Action(() =>
                    {
                        MessageBox.Show("Contraseña no cumple con los requisitos minimos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }));
                }
            }
            this.Invoke(new Action(() => { ButtonGuardar.Enabled = true; }));
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
