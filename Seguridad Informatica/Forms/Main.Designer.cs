namespace Seguridad_Informatica
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            PanelOptions = new Guna.UI2.WinForms.Guna2Panel();
            ButtonConfig = new Guna.UI2.WinForms.Guna2Button();
            ButtonInicio = new Guna.UI2.WinForms.Guna2Button();
            PanelHead = new Guna.UI2.WinForms.Guna2Panel();
            ButtonUser = new Guna.UI2.WinForms.Guna2Button();
            PanelOptions.SuspendLayout();
            PanelHead.SuspendLayout();
            SuspendLayout();
            // 
            // PanelOptions
            // 
            PanelOptions.BackColor = Color.LightGray;
            PanelOptions.Controls.Add(ButtonConfig);
            PanelOptions.Controls.Add(ButtonInicio);
            PanelOptions.CustomizableEdges = customizableEdges5;
            PanelOptions.Dock = DockStyle.Left;
            PanelOptions.Location = new Point(0, 46);
            PanelOptions.Name = "PanelOptions";
            PanelOptions.ShadowDecoration.CustomizableEdges = customizableEdges6;
            PanelOptions.Size = new Size(165, 360);
            PanelOptions.TabIndex = 0;
            // 
            // ButtonConfig
            // 
            ButtonConfig.BorderRadius = 6;
            ButtonConfig.CustomizableEdges = customizableEdges1;
            ButtonConfig.DisabledState.BorderColor = Color.DarkGray;
            ButtonConfig.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonConfig.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonConfig.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonConfig.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonConfig.ForeColor = Color.White;
            ButtonConfig.Location = new Point(12, 133);
            ButtonConfig.Name = "ButtonConfig";
            ButtonConfig.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ButtonConfig.Size = new Size(135, 37);
            ButtonConfig.TabIndex = 19;
            ButtonConfig.Text = "Configuracion";
            // 
            // ButtonInicio
            // 
            ButtonInicio.BorderRadius = 6;
            ButtonInicio.CustomizableEdges = customizableEdges3;
            ButtonInicio.DisabledState.BorderColor = Color.DarkGray;
            ButtonInicio.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonInicio.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonInicio.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonInicio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonInicio.ForeColor = Color.White;
            ButtonInicio.Location = new Point(12, 81);
            ButtonInicio.Name = "ButtonInicio";
            ButtonInicio.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ButtonInicio.Size = new Size(135, 37);
            ButtonInicio.TabIndex = 18;
            ButtonInicio.Text = "Iniciar Sesion";
            // 
            // PanelHead
            // 
            PanelHead.BackColor = SystemColors.AppWorkspace;
            PanelHead.Controls.Add(ButtonUser);
            PanelHead.CustomizableEdges = customizableEdges9;
            PanelHead.Dock = DockStyle.Top;
            PanelHead.Location = new Point(0, 0);
            PanelHead.Name = "PanelHead";
            PanelHead.ShadowDecoration.CustomizableEdges = customizableEdges10;
            PanelHead.Size = new Size(774, 46);
            PanelHead.TabIndex = 1;
            // 
            // ButtonUser
            // 
            ButtonUser.AutoRoundedCorners = true;
            ButtonUser.BackColor = Color.Transparent;
            ButtonUser.BorderRadius = 14;
            ButtonUser.CustomizableEdges = customizableEdges7;
            ButtonUser.DisabledState.BorderColor = Color.DarkGray;
            ButtonUser.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonUser.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonUser.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonUser.FillColor = Color.Transparent;
            ButtonUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonUser.ForeColor = Color.White;
            ButtonUser.Image = (Image)resources.GetObject("ButtonUser.Image");
            ButtonUser.Location = new Point(51, 9);
            ButtonUser.Name = "ButtonUser";
            ButtonUser.ShadowDecoration.CustomizableEdges = customizableEdges8;
            ButtonUser.Size = new Size(30, 31);
            ButtonUser.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 406);
            Controls.Add(PanelOptions);
            Controls.Add(PanelHead);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            PanelOptions.ResumeLayout(false);
            PanelHead.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelOptions;
        private Guna.UI2.WinForms.Guna2Button ButtonInicio;
        private Guna.UI2.WinForms.Guna2Button ButtonConfig;
        private Guna.UI2.WinForms.Guna2Panel PanelHead;
        private Guna.UI2.WinForms.Guna2Button ButtonUser;
    }
}
