using Dominio.Entidades;
using Seguridad_Informatica.Forms;

namespace Seguridad_Informatica
{
    public partial class Main : Form
    {
        public Main(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }
        private Usuario user;

        private void Main_Load(object sender, EventArgs e)
        {
            labelUser.Text = user.Nombre;
        }

        //Carga de SubFormulario
        private void Open_form_panel(object form_panel)
        {
            Form fp = form_panel as Form;
            if (panelcontainer.Controls.Count > 0)
            {
                panelcontainer.Controls.RemoveAt(0);
            }
            fp.TopLevel = false;
            fp.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(fp);
            panelcontainer.Tag = fp;
            fp.Show();
        }
        private void ButtonUser_Click(object sender, EventArgs e)
        {
            Perfil per = new Perfil(user);
            per.ShowDialog();
        }

        private void ButtonCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar sesion?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();
        }

        private void ButtonUsuarios_Click(object sender, EventArgs e)
        {
            Open_form_panel(new Form_Usuarios(user));
        }
    }
}