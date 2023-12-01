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
    public partial class Perfil : Form
    {
        public Perfil(short id)
        {
            InitializeComponent();
            this.id = id;
        }
        private short id;
        private void ButtonUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Perfil_Load(object sender, EventArgs e)
        {
            NUsuarios us = new NUsuarios();
            var user = await us.GetUsarioId(new Usuario { Id = id });
            this.Invoke(new Action(() =>
            {
                label_Nombre.Text = user.Nombre;
                label_Correo.Text = user.Correo;
                label_Usuario.Text = user.Login;
                var estado = (user.Activo.Equals(true)) ? "Activo" : "Inactivo";
                label_estado.Text = estado;
                label_Fecha.Text = user.FechaRegistro.ToString("dd/MM/yyyy");
            }));
        }
    }
}
