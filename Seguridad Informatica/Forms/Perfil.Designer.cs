namespace Seguridad_Informatica.Forms
{
    partial class Perfil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            PanelHead = new Guna.UI2.WinForms.Guna2GradientPanel();
            ButtonUser = new Guna.UI2.WinForms.Guna2Button();
            labelPerfil = new Label();
            labelNombre = new Label();
            labelCorreo = new Label();
            labelUsername = new Label();
            labelEstado = new Label();
            labelFecha = new Label();
            label_Nombre = new Label();
            label_Correo = new Label();
            label_Usuario = new Label();
            label_estado = new Label();
            label_Fecha = new Label();
            PanelHead.SuspendLayout();
            SuspendLayout();
            // 
            // PanelHead
            // 
            PanelHead.BackColor = Color.CadetBlue;
            PanelHead.Controls.Add(ButtonUser);
            PanelHead.Controls.Add(labelPerfil);
            PanelHead.CustomizableEdges = customizableEdges3;
            PanelHead.Dock = DockStyle.Top;
            PanelHead.Location = new Point(0, 0);
            PanelHead.Name = "PanelHead";
            PanelHead.ShadowDecoration.CustomizableEdges = customizableEdges4;
            PanelHead.Size = new Size(371, 46);
            PanelHead.TabIndex = 0;
            // 
            // ButtonUser
            // 
            ButtonUser.Animated = true;
            ButtonUser.AnimatedGIF = true;
            ButtonUser.CustomizableEdges = customizableEdges1;
            ButtonUser.DisabledState.BorderColor = Color.DarkGray;
            ButtonUser.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonUser.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonUser.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonUser.FillColor = Color.Transparent;
            ButtonUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonUser.ForeColor = Color.White;
            ButtonUser.Image = (Image)resources.GetObject("ButtonUser.Image");
            ButtonUser.Location = new Point(332, 7);
            ButtonUser.Name = "ButtonUser";
            ButtonUser.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ButtonUser.Size = new Size(28, 30);
            ButtonUser.TabIndex = 20;
            ButtonUser.Click += ButtonUser_Click;
            // 
            // labelPerfil
            // 
            labelPerfil.AutoSize = true;
            labelPerfil.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelPerfil.Location = new Point(109, 12);
            labelPerfil.Name = "labelPerfil";
            labelPerfil.Size = new Size(152, 25);
            labelPerfil.TabIndex = 0;
            labelPerfil.Text = "Perfil de Usuario";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNombre.Location = new Point(21, 66);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(71, 20);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Nombre:";
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCorreo.Location = new Point(21, 95);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(60, 20);
            labelCorreo.TabIndex = 2;
            labelCorreo.Text = "Correo:";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.Location = new Point(21, 124);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(67, 20);
            labelUsername.TabIndex = 3;
            labelUsername.Text = "Usuario:";
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelEstado.Location = new Point(21, 151);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(60, 20);
            labelEstado.TabIndex = 4;
            labelEstado.Text = "Estado:";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelFecha.Location = new Point(21, 178);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(137, 20);
            labelFecha.TabIndex = 5;
            labelFecha.Text = "Fecha de Registro:";
            // 
            // label_Nombre
            // 
            label_Nombre.AutoSize = true;
            label_Nombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_Nombre.Location = new Point(113, 66);
            label_Nombre.Name = "label_Nombre";
            label_Nombre.Size = new Size(64, 20);
            label_Nombre.TabIndex = 6;
            label_Nombre.Text = "Nombre";
            // 
            // label_Correo
            // 
            label_Correo.AutoSize = true;
            label_Correo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_Correo.Location = new Point(113, 95);
            label_Correo.Name = "label_Correo";
            label_Correo.Size = new Size(54, 20);
            label_Correo.TabIndex = 7;
            label_Correo.Text = "Correo";
            // 
            // label_Usuario
            // 
            label_Usuario.AutoSize = true;
            label_Usuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_Usuario.Location = new Point(113, 124);
            label_Usuario.Name = "label_Usuario";
            label_Usuario.Size = new Size(59, 20);
            label_Usuario.TabIndex = 8;
            label_Usuario.Text = "Usuario";
            // 
            // label_estado
            // 
            label_estado.AutoSize = true;
            label_estado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_estado.Location = new Point(113, 151);
            label_estado.Name = "label_estado";
            label_estado.Size = new Size(54, 20);
            label_estado.TabIndex = 9;
            label_estado.Text = "Estado";
            // 
            // label_Fecha
            // 
            label_Fecha.AutoSize = true;
            label_Fecha.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_Fecha.Location = new Point(164, 178);
            label_Fecha.Name = "label_Fecha";
            label_Fecha.Size = new Size(47, 20);
            label_Fecha.TabIndex = 10;
            label_Fecha.Text = "Fecha";
            // 
            // Perfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(371, 224);
            Controls.Add(label_Fecha);
            Controls.Add(label_estado);
            Controls.Add(label_Usuario);
            Controls.Add(label_Correo);
            Controls.Add(label_Nombre);
            Controls.Add(labelFecha);
            Controls.Add(labelEstado);
            Controls.Add(labelUsername);
            Controls.Add(labelCorreo);
            Controls.Add(labelNombre);
            Controls.Add(PanelHead);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Perfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Perfil";
            Load += Perfil_Load;
            PanelHead.ResumeLayout(false);
            PanelHead.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel PanelHead;
        private Label labelPerfil;
        private Guna.UI2.WinForms.Guna2Button ButtonUser;
        private Label labelNombre;
        private Label labelCorreo;
        private Label labelUsername;
        private Label labelEstado;
        private Label labelFecha;
        private Label label_Nombre;
        private Label label_Correo;
        private Label label_Usuario;
        private Label label_estado;
        private Label label_Fecha;
    }
}