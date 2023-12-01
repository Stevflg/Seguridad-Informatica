namespace Seguridad_Informatica.Forms
{
    partial class Form_Usuarios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Usuarios));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            LabelUsuario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            LabelCorreo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            LabelNombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            TextBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            TextBoxCorreo = new Guna.UI2.WinForms.Guna2TextBox();
            TextBoxNombre = new Guna.UI2.WinForms.Guna2TextBox();
            panel1 = new Panel();
            LabelTitle = new Label();
            DataGridUsuarios = new Guna.UI2.WinForms.Guna2DataGridView();
            ButtonAgregar = new Guna.UI2.WinForms.Guna2Button();
            ButtonEditar = new Guna.UI2.WinForms.Guna2Button();
            ButtonEliminar = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridUsuarios).BeginInit();
            SuspendLayout();
            // 
            // LabelUsuario
            // 
            LabelUsuario.BackColor = Color.Transparent;
            LabelUsuario.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelUsuario.ForeColor = SystemColors.ControlDarkDark;
            LabelUsuario.Location = new Point(249, 54);
            LabelUsuario.Name = "LabelUsuario";
            LabelUsuario.Size = new Size(122, 19);
            LabelUsuario.TabIndex = 15;
            LabelUsuario.Text = "Nombre de Usuario";
            // 
            // LabelCorreo
            // 
            LabelCorreo.BackColor = Color.Transparent;
            LabelCorreo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelCorreo.ForeColor = SystemColors.ControlDarkDark;
            LabelCorreo.Location = new Point(32, 104);
            LabelCorreo.Name = "LabelCorreo";
            LabelCorreo.Size = new Size(114, 19);
            LabelCorreo.TabIndex = 14;
            LabelCorreo.Text = "Correo Electronico";
            // 
            // LabelNombre
            // 
            LabelNombre.BackColor = Color.Transparent;
            LabelNombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelNombre.ForeColor = SystemColors.ControlDarkDark;
            LabelNombre.Location = new Point(32, 54);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(53, 19);
            LabelNombre.TabIndex = 13;
            LabelNombre.Text = "Nombre";
            // 
            // TextBoxUsername
            // 
            TextBoxUsername.CustomizableEdges = customizableEdges1;
            TextBoxUsername.DefaultText = "";
            TextBoxUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBoxUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBoxUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBoxUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBoxUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBoxUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBoxUsername.Location = new Point(249, 74);
            TextBoxUsername.Name = "TextBoxUsername";
            TextBoxUsername.PasswordChar = '\0';
            TextBoxUsername.PlaceholderText = "Usuario";
            TextBoxUsername.SelectedText = "";
            TextBoxUsername.ShadowDecoration.CustomizableEdges = customizableEdges2;
            TextBoxUsername.Size = new Size(200, 27);
            TextBoxUsername.TabIndex = 11;
            // 
            // TextBoxCorreo
            // 
            TextBoxCorreo.CustomizableEdges = customizableEdges3;
            TextBoxCorreo.DefaultText = "";
            TextBoxCorreo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBoxCorreo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBoxCorreo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBoxCorreo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBoxCorreo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBoxCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxCorreo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBoxCorreo.Location = new Point(32, 124);
            TextBoxCorreo.Name = "TextBoxCorreo";
            TextBoxCorreo.PasswordChar = '\0';
            TextBoxCorreo.PlaceholderText = "Correo";
            TextBoxCorreo.SelectedText = "";
            TextBoxCorreo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            TextBoxCorreo.Size = new Size(200, 27);
            TextBoxCorreo.TabIndex = 10;
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.CustomizableEdges = customizableEdges5;
            TextBoxNombre.DefaultText = "";
            TextBoxNombre.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBoxNombre.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBoxNombre.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBoxNombre.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBoxNombre.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBoxNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxNombre.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBoxNombre.Location = new Point(32, 74);
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.PasswordChar = '\0';
            TextBoxNombre.PlaceholderText = "Nombre";
            TextBoxNombre.SelectedText = "";
            TextBoxNombre.ShadowDecoration.CustomizableEdges = customizableEdges6;
            TextBoxNombre.Size = new Size(200, 27);
            TextBoxNombre.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(LabelTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(609, 42);
            panel1.TabIndex = 17;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(174, 9);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(256, 25);
            LabelTitle.TabIndex = 0;
            LabelTitle.Text = "Administración de Usuarios";
            // 
            // DataGridUsuarios
            // 
            DataGridUsuarios.AllowUserToAddRows = false;
            DataGridUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridUsuarios.ColumnHeadersHeight = 4;
            DataGridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridUsuarios.GridColor = Color.FromArgb(231, 229, 255);
            DataGridUsuarios.Location = new Point(33, 157);
            DataGridUsuarios.Name = "DataGridUsuarios";
            DataGridUsuarios.ReadOnly = true;
            DataGridUsuarios.RowHeadersVisible = false;
            DataGridUsuarios.RowTemplate.Height = 25;
            DataGridUsuarios.Size = new Size(544, 171);
            DataGridUsuarios.TabIndex = 18;
            DataGridUsuarios.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridUsuarios.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridUsuarios.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridUsuarios.ThemeStyle.BackColor = Color.White;
            DataGridUsuarios.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridUsuarios.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridUsuarios.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            DataGridUsuarios.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridUsuarios.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridUsuarios.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridUsuarios.ThemeStyle.HeaderStyle.Height = 4;
            DataGridUsuarios.ThemeStyle.ReadOnly = true;
            DataGridUsuarios.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridUsuarios.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridUsuarios.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridUsuarios.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridUsuarios.ThemeStyle.RowsStyle.Height = 25;
            DataGridUsuarios.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridUsuarios.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridUsuarios.CellClick += DataGridUsuarios_CellClick;
            // 
            // ButtonAgregar
            // 
            ButtonAgregar.BorderRadius = 6;
            ButtonAgregar.CustomizableEdges = customizableEdges7;
            ButtonAgregar.DisabledState.BorderColor = Color.DarkGray;
            ButtonAgregar.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonAgregar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonAgregar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonAgregar.ForeColor = Color.White;
            ButtonAgregar.Image = (Image)resources.GetObject("ButtonAgregar.Image");
            ButtonAgregar.ImageAlign = HorizontalAlignment.Left;
            ButtonAgregar.Location = new Point(248, 124);
            ButtonAgregar.Name = "ButtonAgregar";
            ButtonAgregar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            ButtonAgregar.Size = new Size(92, 23);
            ButtonAgregar.TabIndex = 19;
            ButtonAgregar.Text = "Agregar";
            ButtonAgregar.TextAlign = HorizontalAlignment.Left;
            ButtonAgregar.Click += ButtonAgregar_Click;
            // 
            // ButtonEditar
            // 
            ButtonEditar.BorderRadius = 6;
            ButtonEditar.CustomizableEdges = customizableEdges9;
            ButtonEditar.DisabledState.BorderColor = Color.DarkGray;
            ButtonEditar.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonEditar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonEditar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonEditar.Enabled = false;
            ButtonEditar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonEditar.ForeColor = Color.White;
            ButtonEditar.Image = (Image)resources.GetObject("ButtonEditar.Image");
            ButtonEditar.ImageAlign = HorizontalAlignment.Left;
            ButtonEditar.Location = new Point(444, 124);
            ButtonEditar.Name = "ButtonEditar";
            ButtonEditar.ShadowDecoration.CustomizableEdges = customizableEdges10;
            ButtonEditar.Size = new Size(92, 23);
            ButtonEditar.TabIndex = 20;
            ButtonEditar.Text = "Editar";
            ButtonEditar.TextAlign = HorizontalAlignment.Left;
            ButtonEditar.Click += ButtonEditar_Click;
            // 
            // ButtonEliminar
            // 
            ButtonEliminar.BorderRadius = 6;
            ButtonEliminar.CustomizableEdges = customizableEdges11;
            ButtonEliminar.DisabledState.BorderColor = Color.DarkGray;
            ButtonEliminar.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonEliminar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonEliminar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonEliminar.Enabled = false;
            ButtonEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonEliminar.ForeColor = Color.White;
            ButtonEliminar.Image = (Image)resources.GetObject("ButtonEliminar.Image");
            ButtonEliminar.ImageAlign = HorizontalAlignment.Left;
            ButtonEliminar.Location = new Point(346, 124);
            ButtonEliminar.Name = "ButtonEliminar";
            ButtonEliminar.ShadowDecoration.CustomizableEdges = customizableEdges12;
            ButtonEliminar.Size = new Size(92, 23);
            ButtonEliminar.TabIndex = 21;
            ButtonEliminar.Text = "Eliminar";
            ButtonEliminar.TextAlign = HorizontalAlignment.Left;
            ButtonEliminar.Click += ButtonEliminar_Click;
            // 
            // Form_Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 349);
            Controls.Add(ButtonEliminar);
            Controls.Add(ButtonEditar);
            Controls.Add(ButtonAgregar);
            Controls.Add(DataGridUsuarios);
            Controls.Add(panel1);
            Controls.Add(LabelUsuario);
            Controls.Add(LabelCorreo);
            Controls.Add(LabelNombre);
            Controls.Add(TextBoxUsername);
            Controls.Add(TextBoxCorreo);
            Controls.Add(TextBoxNombre);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Usuarios";
            Text = "Inicio";
            Load += Form_Usuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelUsuario;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelCorreo;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelNombre;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxUsername;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxCorreo;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxNombre;
        private Panel panel1;
        private Label LabelTitle;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridUsuarios;
        private Guna.UI2.WinForms.Guna2Button ButtonAgregar;
        private Guna.UI2.WinForms.Guna2Button ButtonEditar;
        private Guna.UI2.WinForms.Guna2Button ButtonEliminar;
    }
}