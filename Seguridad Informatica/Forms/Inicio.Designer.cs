﻿namespace Seguridad_Informatica.Forms
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            LabelHead = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LabelHead
            // 
            LabelHead.BackColor = Color.Transparent;
            LabelHead.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LabelHead.ForeColor = SystemColors.ControlDarkDark;
            LabelHead.Location = new Point(311, 101);
            LabelHead.Name = "LabelHead";
            LabelHead.Size = new Size(259, 34);
            LabelHead.TabIndex = 17;
            LabelHead.Text = "Seguridad Informatica";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(341, 158);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 422);
            Controls.Add(pictureBox1);
            Controls.Add(LabelHead);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Inicio";
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel LabelHead;
        private PictureBox pictureBox1;
    }
}