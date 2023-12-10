namespace Seguridad_Informatica.Forms
{
    partial class Configuracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracion));
            pictureBox1 = new PictureBox();
            LabelHead = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(381, 168);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // LabelHead
            // 
            LabelHead.BackColor = Color.Transparent;
            LabelHead.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LabelHead.ForeColor = SystemColors.ControlDarkDark;
            LabelHead.Location = new Point(350, 99);
            LabelHead.Name = "LabelHead";
            LabelHead.Size = new Size(190, 34);
            LabelHead.TabIndex = 19;
            LabelHead.Text = "Configuraciones";
            // 
            // Configuracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 422);
            Controls.Add(pictureBox1);
            Controls.Add(LabelHead);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Configuracion";
            Text = "Configuracion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelHead;
    }
}