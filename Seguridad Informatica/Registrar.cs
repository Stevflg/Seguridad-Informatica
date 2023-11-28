using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguridad_Informatica
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }
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
            if(!ContraseñaSegura(TextBoxContraseña.Text))
            {
                TextBoxContraseña.FocusedState.BorderColor = Color.Red;
                TextBoxContraseña.BorderColor = Color.Red;
            }
            else
            {
                TextBoxContraseña.FocusedState.BorderColor = Color.Green;
                TextBoxContraseña.BorderColor= Color.Green;
            }
        }
    }
}
