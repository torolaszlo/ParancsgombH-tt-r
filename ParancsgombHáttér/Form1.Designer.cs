﻿namespace ParancsgombHáttér
{
    partial class Form1
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
            this.Tároló = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Tároló
            // 
            this.Tároló.Dock = System.Windows.Forms.DockStyle.Right;
            this.Tároló.Location = new System.Drawing.Point(180, 0);
            this.Tároló.Name = "Tároló";
            this.Tároló.Size = new System.Drawing.Size(649, 450);
            this.Tároló.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.Tároló);
            this.Name = "Form1";
            this.Text = "AlkalmazásAblak";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Tároló;
    }
}

