﻿namespace Convocatoria
{
    partial class Form1
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
            label1 = new Label();
            btnEst = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(91, 33);
            label1.Name = "label1";
            label1.Size = new Size(280, 32);
            label1.TabIndex = 0;
            label1.Text = "REGISTROS ESCOLARES";
            // 
            // btnEst
            // 
            btnEst.BackColor = SystemColors.ActiveCaption;
            btnEst.Location = new Point(120, 109);
            btnEst.Name = "btnEst";
            btnEst.Size = new Size(206, 99);
            btnEst.TabIndex = 2;
            btnEst.Text = "REALIZAR REGISTROS ";
            btnEst.UseVisualStyleBackColor = false;
            btnEst.Click += btnEst_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 318);
            Controls.Add(btnEst);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Registros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEst;
    }
}