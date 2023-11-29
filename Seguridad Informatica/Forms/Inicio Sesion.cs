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
    public partial class Inicio_Sesion : Form
    {
        private readonly NInicioSesion InicioSesion;
        public Inicio_Sesion()
        {
            InitializeComponent();
            this.InicioSesion = new NInicioSesion();
        }
        public async void Login()
        {
            if (!string.IsNullOrEmpty(TextBoxCorreo.Text) && !string.IsNullOrEmpty(TextBoxContraseña.Text))
            {
                Usuario usuario = new Usuario
                {
                    Correo = TextBoxCorreo.Text,
                    Password = Encrypt.EncryptPass(TextBoxContraseña.Text)
                };
                var result = await InicioSesion.Login(usuario);
                if (result)
                {
                    this.Invoke(new Action(() => {
                        Main formMain = new Main();
                        this.Hide();
                        formMain.ShowDialog();
                        this.Close();
                    }));
                }
                else
                {
                    this.Invoke(new Action(() => {
                        TextBoxContraseña.Clear();
                        MessageBox.Show("Credenciales Incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }));
                }
            }
            else
            {
                this.Invoke(new Action(() => {
                    MessageBox.Show("Los campos no pueden estar vacios", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
            }
        }

        private void LinkAyuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private  void ButtonLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
