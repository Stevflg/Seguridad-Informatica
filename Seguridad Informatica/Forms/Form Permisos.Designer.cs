namespace Seguridad_Informatica.Forms
{
    partial class Form_Permisos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Permisos));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            LabelHead = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ComboBoxUsuario = new Guna.UI2.WinForms.Guna2ComboBox();
            LabelUsuario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            LabelRol = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ComboBoxRol = new Guna.UI2.WinForms.Guna2ComboBox();
            DataGridViewPermiso = new Guna.UI2.WinForms.Guna2DataGridView();
            ButtonEliminar = new Guna.UI2.WinForms.Guna2Button();
            ButtonAgregar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewPermiso).BeginInit();
            SuspendLayout();
            // 
            // LabelHead
            // 
            LabelHead.BackColor = Color.Transparent;
            LabelHead.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelHead.ForeColor = SystemColors.ControlDarkDark;
            LabelHead.Location = new Point(271, 12);
            LabelHead.Name = "LabelHead";
            LabelHead.Size = new Size(75, 23);
            LabelHead.TabIndex = 16;
            LabelHead.Text = "Permisos";
            // 
            // ComboBoxUsuario
            // 
            ComboBoxUsuario.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboBoxUsuario.BackColor = Color.Transparent;
            ComboBoxUsuario.BorderColor = Color.FromArgb(192, 0, 0);
            ComboBoxUsuario.BorderRadius = 5;
            ComboBoxUsuario.CustomizableEdges = customizableEdges1;
            ComboBoxUsuario.DrawMode = DrawMode.OwnerDrawFixed;
            ComboBoxUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxUsuario.FocusedColor = Color.FromArgb(94, 148, 255);
            ComboBoxUsuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ComboBoxUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxUsuario.ForeColor = Color.FromArgb(68, 88, 112);
            ComboBoxUsuario.ItemHeight = 30;
            ComboBoxUsuario.Location = new Point(73, 93);
            ComboBoxUsuario.Name = "ComboBoxUsuario";
            ComboBoxUsuario.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ComboBoxUsuario.Size = new Size(166, 36);
            ComboBoxUsuario.TabIndex = 17;
            ComboBoxUsuario.SelectedIndexChanged += ComboBoxUsuario_SelectedIndexChanged;
            // 
            // LabelUsuario
            // 
            LabelUsuario.BackColor = Color.Transparent;
            LabelUsuario.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelUsuario.ForeColor = SystemColors.ControlDarkDark;
            LabelUsuario.Location = new Point(73, 69);
            LabelUsuario.Name = "LabelUsuario";
            LabelUsuario.Size = new Size(56, 22);
            LabelUsuario.TabIndex = 18;
            LabelUsuario.Text = "Usuario";
            // 
            // LabelRol
            // 
            LabelRol.BackColor = Color.Transparent;
            LabelRol.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelRol.ForeColor = SystemColors.ControlDarkDark;
            LabelRol.Location = new Point(274, 69);
            LabelRol.Name = "LabelRol";
            LabelRol.Size = new Size(25, 22);
            LabelRol.TabIndex = 19;
            LabelRol.Text = "Rol";
            // 
            // ComboBoxRol
            // 
            ComboBoxRol.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboBoxRol.BackColor = Color.Transparent;
            ComboBoxRol.BorderColor = Color.FromArgb(192, 0, 0);
            ComboBoxRol.BorderRadius = 5;
            ComboBoxRol.CustomizableEdges = customizableEdges3;
            ComboBoxRol.DrawMode = DrawMode.OwnerDrawFixed;
            ComboBoxRol.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxRol.FocusedColor = Color.FromArgb(94, 148, 255);
            ComboBoxRol.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ComboBoxRol.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxRol.ForeColor = Color.FromArgb(68, 88, 112);
            ComboBoxRol.ItemHeight = 30;
            ComboBoxRol.Location = new Point(271, 93);
            ComboBoxRol.Name = "ComboBoxRol";
            ComboBoxRol.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ComboBoxRol.Size = new Size(151, 36);
            ComboBoxRol.TabIndex = 20;
            ComboBoxRol.SelectedIndexChanged += ComboBoxRol_SelectedIndexChanged;
            // 
            // DataGridViewPermiso
            // 
            DataGridViewPermiso.AllowUserToAddRows = false;
            DataGridViewPermiso.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewPermiso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridViewPermiso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewPermiso.ColumnHeadersHeight = 4;
            DataGridViewPermiso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridViewPermiso.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridViewPermiso.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewPermiso.Location = new Point(69, 151);
            DataGridViewPermiso.Name = "DataGridViewPermiso";
            DataGridViewPermiso.ReadOnly = true;
            DataGridViewPermiso.RowHeadersVisible = false;
            DataGridViewPermiso.RowTemplate.Height = 25;
            DataGridViewPermiso.Size = new Size(475, 186);
            DataGridViewPermiso.TabIndex = 21;
            DataGridViewPermiso.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridViewPermiso.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridViewPermiso.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridViewPermiso.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridViewPermiso.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridViewPermiso.ThemeStyle.BackColor = Color.White;
            DataGridViewPermiso.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewPermiso.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridViewPermiso.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewPermiso.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridViewPermiso.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridViewPermiso.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridViewPermiso.ThemeStyle.HeaderStyle.Height = 4;
            DataGridViewPermiso.ThemeStyle.ReadOnly = true;
            DataGridViewPermiso.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridViewPermiso.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridViewPermiso.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridViewPermiso.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridViewPermiso.ThemeStyle.RowsStyle.Height = 25;
            DataGridViewPermiso.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridViewPermiso.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // ButtonEliminar
            // 
            ButtonEliminar.BorderRadius = 6;
            ButtonEliminar.CustomizableEdges = customizableEdges5;
            ButtonEliminar.DisabledState.BorderColor = Color.DarkGray;
            ButtonEliminar.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonEliminar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonEliminar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonEliminar.Enabled = false;
            ButtonEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonEliminar.ForeColor = Color.White;
            ButtonEliminar.Image = (Image)resources.GetObject("ButtonEliminar.Image");
            ButtonEliminar.ImageAlign = HorizontalAlignment.Left;
            ButtonEliminar.Location = new Point(452, 106);
            ButtonEliminar.Name = "ButtonEliminar";
            ButtonEliminar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ButtonEliminar.Size = new Size(92, 23);
            ButtonEliminar.TabIndex = 23;
            ButtonEliminar.Text = "Eliminar";
            ButtonEliminar.TextAlign = HorizontalAlignment.Left;
            ButtonEliminar.Click += ButtonEliminar_Click;
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
            ButtonAgregar.Location = new Point(452, 77);
            ButtonAgregar.Name = "ButtonAgregar";
            ButtonAgregar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            ButtonAgregar.Size = new Size(92, 23);
            ButtonAgregar.TabIndex = 22;
            ButtonAgregar.Text = "Agregar";
            ButtonAgregar.TextAlign = HorizontalAlignment.Left;
            ButtonAgregar.Click += ButtonAgregar_Click;
            // 
            // Form_Permisos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 349);
            Controls.Add(ButtonEliminar);
            Controls.Add(ButtonAgregar);
            Controls.Add(DataGridViewPermiso);
            Controls.Add(ComboBoxRol);
            Controls.Add(LabelRol);
            Controls.Add(LabelUsuario);
            Controls.Add(ComboBoxUsuario);
            Controls.Add(LabelHead);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Permisos";
            Text = "Form_Permisos";
            Load += Form_Permisos_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewPermiso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel LabelHead;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxUsuario;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelUsuario;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelRol;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxRol;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewPermiso;
        private Guna.UI2.WinForms.Guna2Button ButtonEliminar;
        private Guna.UI2.WinForms.Guna2Button ButtonAgregar;
    }
}