namespace Seguridad_Informatica.Forms
{
    partial class Editar_Usuario
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_Usuario));
            ButtonGuardar = new Guna.UI2.WinForms.Guna2Button();
            ButtonCancelar = new Guna.UI2.WinForms.Guna2Button();
            LabelContraseña = new Guna.UI2.WinForms.Guna2HtmlLabel();
            LabelUsuario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            LabelCorreo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            LabelNombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            LabelHead = new Guna.UI2.WinForms.Guna2HtmlLabel();
            TextBoxContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            TextBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            TextBoxCorreo = new Guna.UI2.WinForms.Guna2TextBox();
            TextBoxNombre = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // ButtonGuardar
            // 
            ButtonGuardar.BorderRadius = 6;
            ButtonGuardar.CustomizableEdges = customizableEdges1;
            ButtonGuardar.DisabledState.BorderColor = Color.DarkGray;
            ButtonGuardar.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonGuardar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonGuardar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonGuardar.ForeColor = Color.White;
            ButtonGuardar.Location = new Point(246, 217);
            ButtonGuardar.Name = "ButtonGuardar";
            ButtonGuardar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ButtonGuardar.Size = new Size(134, 40);
            ButtonGuardar.TabIndex = 21;
            ButtonGuardar.Text = "Guardar Cambios";
            ButtonGuardar.Click += ButtonGuardar_Click;
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.BorderRadius = 6;
            ButtonCancelar.CustomizableEdges = customizableEdges3;
            ButtonCancelar.DisabledState.BorderColor = Color.DarkGray;
            ButtonCancelar.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonCancelar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonCancelar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonCancelar.ForeColor = Color.White;
            ButtonCancelar.Location = new Point(95, 217);
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ButtonCancelar.Size = new Size(134, 40);
            ButtonCancelar.TabIndex = 20;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.Click += ButtonCancelar_Click;
            // 
            // LabelContraseña
            // 
            LabelContraseña.BackColor = Color.Transparent;
            LabelContraseña.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelContraseña.ForeColor = SystemColors.ControlDarkDark;
            LabelContraseña.Location = new Point(246, 122);
            LabelContraseña.Name = "LabelContraseña";
            LabelContraseña.Size = new Size(72, 19);
            LabelContraseña.TabIndex = 19;
            LabelContraseña.Text = "Contraseña";
            // 
            // LabelUsuario
            // 
            LabelUsuario.BackColor = Color.Transparent;
            LabelUsuario.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelUsuario.ForeColor = SystemColors.ControlDarkDark;
            LabelUsuario.Location = new Point(246, 58);
            LabelUsuario.Name = "LabelUsuario";
            LabelUsuario.Size = new Size(122, 19);
            LabelUsuario.TabIndex = 18;
            LabelUsuario.Text = "Nombre de Usuario";
            // 
            // LabelCorreo
            // 
            LabelCorreo.BackColor = Color.Transparent;
            LabelCorreo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelCorreo.ForeColor = SystemColors.ControlDarkDark;
            LabelCorreo.Location = new Point(29, 122);
            LabelCorreo.Name = "LabelCorreo";
            LabelCorreo.Size = new Size(114, 19);
            LabelCorreo.TabIndex = 17;
            LabelCorreo.Text = "Correo Electronico";
            // 
            // LabelNombre
            // 
            LabelNombre.BackColor = Color.Transparent;
            LabelNombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelNombre.ForeColor = SystemColors.ControlDarkDark;
            LabelNombre.Location = new Point(29, 58);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(53, 19);
            LabelNombre.TabIndex = 16;
            LabelNombre.Text = "Nombre";
            // 
            // LabelHead
            // 
            LabelHead.BackColor = Color.Transparent;
            LabelHead.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelHead.ForeColor = SystemColors.ControlDarkDark;
            LabelHead.Location = new Point(173, 14);
            LabelHead.Name = "LabelHead";
            LabelHead.Size = new Size(115, 23);
            LabelHead.TabIndex = 15;
            LabelHead.Text = "Editar Usuario";
            // 
            // TextBoxContraseña
            // 
            TextBoxContraseña.CustomizableEdges = customizableEdges5;
            TextBoxContraseña.DefaultText = "";
            TextBoxContraseña.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBoxContraseña.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBoxContraseña.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBoxContraseña.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBoxContraseña.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBoxContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxContraseña.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBoxContraseña.Location = new Point(246, 146);
            TextBoxContraseña.Name = "TextBoxContraseña";
            TextBoxContraseña.PasswordChar = '*';
            TextBoxContraseña.PlaceholderText = "Contraseña";
            TextBoxContraseña.SelectedText = "";
            TextBoxContraseña.ShadowDecoration.CustomizableEdges = customizableEdges6;
            TextBoxContraseña.Size = new Size(200, 33);
            TextBoxContraseña.TabIndex = 14;
            // 
            // TextBoxUsername
            // 
            TextBoxUsername.CustomizableEdges = customizableEdges7;
            TextBoxUsername.DefaultText = "";
            TextBoxUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBoxUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBoxUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBoxUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBoxUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBoxUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBoxUsername.Location = new Point(246, 83);
            TextBoxUsername.Name = "TextBoxUsername";
            TextBoxUsername.PasswordChar = '\0';
            TextBoxUsername.PlaceholderText = "Usuario";
            TextBoxUsername.SelectedText = "";
            TextBoxUsername.ShadowDecoration.CustomizableEdges = customizableEdges8;
            TextBoxUsername.Size = new Size(200, 33);
            TextBoxUsername.TabIndex = 13;
            // 
            // TextBoxCorreo
            // 
            TextBoxCorreo.CustomizableEdges = customizableEdges9;
            TextBoxCorreo.DefaultText = "";
            TextBoxCorreo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBoxCorreo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBoxCorreo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBoxCorreo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBoxCorreo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBoxCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxCorreo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBoxCorreo.Location = new Point(29, 146);
            TextBoxCorreo.Name = "TextBoxCorreo";
            TextBoxCorreo.PasswordChar = '\0';
            TextBoxCorreo.PlaceholderText = "Correo";
            TextBoxCorreo.SelectedText = "";
            TextBoxCorreo.ShadowDecoration.CustomizableEdges = customizableEdges10;
            TextBoxCorreo.Size = new Size(200, 33);
            TextBoxCorreo.TabIndex = 12;
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.CustomizableEdges = customizableEdges11;
            TextBoxNombre.DefaultText = "";
            TextBoxNombre.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBoxNombre.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBoxNombre.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBoxNombre.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBoxNombre.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBoxNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxNombre.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBoxNombre.Location = new Point(29, 83);
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.PasswordChar = '\0';
            TextBoxNombre.PlaceholderText = "Nombre";
            TextBoxNombre.SelectedText = "";
            TextBoxNombre.ShadowDecoration.CustomizableEdges = customizableEdges12;
            TextBoxNombre.Size = new Size(200, 33);
            TextBoxNombre.TabIndex = 11;
            // 
            // Editar_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 290);
            Controls.Add(ButtonGuardar);
            Controls.Add(ButtonCancelar);
            Controls.Add(LabelContraseña);
            Controls.Add(LabelUsuario);
            Controls.Add(LabelCorreo);
            Controls.Add(LabelNombre);
            Controls.Add(LabelHead);
            Controls.Add(TextBoxContraseña);
            Controls.Add(TextBoxUsername);
            Controls.Add(TextBoxCorreo);
            Controls.Add(TextBoxNombre);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Editar_Usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar_Usuario";
            Load += Editar_Usuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button ButtonGuardar;
        private Guna.UI2.WinForms.Guna2Button ButtonCancelar;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelContraseña;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelUsuario;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelCorreo;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelHead;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxContraseña;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxUsername;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxCorreo;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxNombre;
    }
}