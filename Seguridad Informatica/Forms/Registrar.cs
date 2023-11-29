using Dominio.Entidades;
using Negocio.Procedimientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguridad_Informatica
{
    public partial class Registrar : Form
    {
        private readonly NUsuarios Nusuario;
        private int initial = 0;
        public Registrar()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            Nusuario = new NUsuarios();
            initial = 1;
        }
        private readonly Usuario usuario;
        public Registrar(Usuario user)
        {
            InitializeComponent();
            Nusuario = new NUsuarios();     
            usuario = user;
        }
        # region Validacion de contraseña segura
        private bool ContraseñaSegura(string Contraseña)
        {
            Regex letras = new(@"[a-zA-z]");
            Regex numeros = new Regex(@"[0-9]");
            Regex caracEsp = new Regex("[!\"#\\$%&'()*+,-./:;=?@\\[\\]^_`{|}~]");
            var result = (letras.IsMatch(Contraseña) && numeros.IsMatch(Contraseña) && caracEsp.IsMatch(Contraseña) && Contraseña.Length > 9) ? true : false;
            return result;
        }

        private void TextBoxContraseña_TextChanged(object sender, EventArgs e)
        {
            if (!ContraseñaSegura(TextBoxContraseña.Text))
            {
                TextBoxContraseña.FocusedState.BorderColor = Color.Red;
                TextBoxContraseña.BorderColor = Color.Red;
            }
            else
            {
                TextBoxContraseña.FocusedState.BorderColor = Color.Green;
                TextBoxContraseña.BorderColor = Color.Green;
            }
        }
        #endregion

        private async void Create()
        {
            if (!string.IsNullOrEmpty(TextBoxNombre.Text) || (!string.IsNullOrEmpty(TextBoxCorreo.Text)) ||
                !string.IsNullOrEmpty(TextBoxUsername.Text) || !string.IsNullOrEmpty(TextBoxContraseña.Text))
            {
                if (!ContraseñaSegura(TextBoxContraseña.Text))
                {
                    this.Invoke(new Action(() =>
                    {
                        MessageBox.Show("Contraseña no contiene los requerimientos minimos \n" +
                         "como 10 caracteres entre mayusculas, minusculas, caracteres especiales y numeros", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }));
                }
                else
                {
                    Usuario usuario = new Usuario
                    {
                        Nombre = TextBoxNombre.Text,
                        Correo = TextBoxCorreo.Text,
                        Login = TextBoxUsername.Text,
                        Password = Encrypt.EncryptPass(TextBoxContraseña.Text),
                        Contador = 0,
                        Bloqueado = false,
                        Activo = true,
                        FechaRegistro = DateTime.Now,
                        UsuarioRegistro = 1,
                    };
                    var result = await Nusuario.Create(usuario);
                    this.Invoke(new Action(() =>
                    {
                        MessageBox.Show(result, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (initial.Equals(1)) this.Close();
                    }));
                }
            }
            else
            {
                MessageBox.Show("Rellene los campos vacios", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void ButtonGuardar_Click(object sender, EventArgs e)
        {
            this.Invoke(new Action(() => { ButtonGuardar.Enabled = false; }));
            await Task.Run(() => { Create(); });
            this.Invoke(new Action(() => { ButtonGuardar.Enabled = true;  }));
        }
    }
}