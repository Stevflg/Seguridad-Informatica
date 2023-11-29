namespace Seguridad_Informatica.Forms
{
    partial class Inicio_Sesion
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio_Sesion));
            ButtonLogin = new Guna.UI2.WinForms.Guna2Button();
            LabelContraseña = new Guna.UI2.WinForms.Guna2HtmlLabel();
            LabelCorreo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            TextBoxContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            TextBoxCorreo = new Guna.UI2.WinForms.Guna2TextBox();
            pictureBoxEmail = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ButtonLogin
            // 
            ButtonLogin.BorderRadius = 6;
            ButtonLogin.CustomizableEdges = customizableEdges1;
            ButtonLogin.DisabledState.BorderColor = Color.DarkGray;
            ButtonLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonLogin.ForeColor = Color.White;
            ButtonLogin.Location = new Point(128, 261);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ButtonLogin.Size = new Size(97, 27);
            ButtonLogin.TabIndex = 17;
            ButtonLogin.Text = "Iniciar Sesion";
            // 
            // LabelContraseña
            // 
            LabelContraseña.BackColor = Color.Transparent;
            LabelContraseña.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelContraseña.ForeColor = SystemColors.ControlDarkDark;
            LabelContraseña.Location = new Point(79, 179);
            LabelContraseña.Name = "LabelContraseña";
            LabelContraseña.Size = new Size(72, 19);
            LabelContraseña.TabIndex = 15;
            LabelContraseña.Text = "Contraseña";
            // 
            // LabelCorreo
            // 
            LabelCorreo.BackColor = Color.Transparent;
            LabelCorreo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelCorreo.ForeColor = SystemColors.ControlDarkDark;
            LabelCorreo.Location = new Point(79, 116);
            LabelCorreo.Name = "LabelCorreo";
            LabelCorreo.Size = new Size(114, 19);
            LabelCorreo.TabIndex = 14;
            LabelCorreo.Text = "Correo Electronico";
            // 
            // TextBoxContraseña
            // 
            TextBoxContraseña.CustomizableEdges = customizableEdges3;
            TextBoxContraseña.DefaultText = "";
            TextBoxContraseña.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBoxContraseña.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBoxContraseña.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBoxContraseña.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBoxContraseña.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBoxContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxContraseña.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBoxContraseña.Location = new Point(79, 203);
            TextBoxContraseña.Name = "TextBoxContraseña";
            TextBoxContraseña.PasswordChar = '\0';
            TextBoxContraseña.PlaceholderText = "Contraseña";
            TextBoxContraseña.SelectedText = "";
            TextBoxContraseña.ShadowDecoration.CustomizableEdges = customizableEdges4;
            TextBoxContraseña.Size = new Size(200, 33);
            TextBoxContraseña.TabIndex = 12;
            // 
            // TextBoxCorreo
            // 
            TextBoxCorreo.CustomizableEdges = customizableEdges5;
            TextBoxCorreo.DefaultText = "";
            TextBoxCorreo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBoxCorreo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBoxCorreo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBoxCorreo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBoxCorreo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBoxCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxCorreo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBoxCorreo.Location = new Point(79, 140);
            TextBoxCorreo.Name = "TextBoxCorreo";
            TextBoxCorreo.PasswordChar = '\0';
            TextBoxCorreo.PlaceholderText = "Correo";
            TextBoxCorreo.SelectedText = "";
            TextBoxCorreo.ShadowDecoration.CustomizableEdges = customizableEdges6;
            TextBoxCorreo.Size = new Size(200, 33);
            TextBoxCorreo.TabIndex = 11;
            // 
            // pictureBoxEmail
            // 
            pictureBoxEmail.BackColor = Color.Transparent;
            pictureBoxEmail.Image = (Image)resources.GetObject("pictureBoxEmail.Image");
            pictureBoxEmail.Location = new Point(53, 144);
            pictureBoxEmail.Name = "pictureBoxEmail";
            pictureBoxEmail.Size = new Size(24, 23);
            pictureBoxEmail.TabIndex = 18;
            pictureBoxEmail.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(53, 207);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 23);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(133, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(94, 95);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // Inicio_Sesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 327);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBoxEmail);
            Controls.Add(ButtonLogin);
            Controls.Add(LabelContraseña);
            Controls.Add(LabelCorreo);
            Controls.Add(TextBoxContraseña);
            Controls.Add(TextBoxCorreo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Inicio_Sesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio Sesion";
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button ButtonLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelContraseña;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelCorreo;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxContraseña;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxCorreo;
        private PictureBox pictureBoxEmail;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}