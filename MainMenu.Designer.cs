﻿namespace PlairesEmulator
{
    partial class MainMenu
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
            this.btnPLV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPRM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPLV
            // 
            this.btnPLV.Location = new System.Drawing.Point(25, 60);
            this.btnPLV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPLV.Name = "btnPLV";
            this.btnPLV.Size = new System.Drawing.Size(197, 28);
            this.btnPLV.TabIndex = 0;
            this.btnPLV.Text = "Plan Location Verification";
            this.btnPLV.UseVisualStyleBackColor = true;
            this.btnPLV.Click += new System.EventHandler(this.btnPLV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Main Menu";
            // 
            // btnPRM
            // 
            this.btnPRM.Location = new System.Drawing.Point(25, 96);
            this.btnPRM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPRM.Name = "btnPRM";
            this.btnPRM.Size = new System.Drawing.Size(197, 28);
            this.btnPRM.TabIndex = 2;
            this.btnPRM.Text = "Plan Request Monitoring";
            this.btnPRM.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 140);
            this.Controls.Add(this.btnPRM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPLV);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainMenu";
            this.Text = "pLaiRes Emulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPLV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPRM;
    }
}

