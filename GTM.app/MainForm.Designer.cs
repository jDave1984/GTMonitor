﻿namespace GTM.app
{
    partial class MainForm
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GameFolder = new System.Windows.Forms.Label();
            this.TestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameFolder
            // 
            this.GameFolder.Location = new System.Drawing.Point(12, 9);
            this.GameFolder.Name = "GameFolder";
            this.GameFolder.Size = new System.Drawing.Size(776, 23);
            this.GameFolder.TabIndex = 0;
            this.GameFolder.Text = "label1";
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(179, 174);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 1;
            this.TestButton.Text = "button1";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.GameFolder);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grant Tactician Monitor";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button TestButton;

        private System.Windows.Forms.Label GameFolder;

        #endregion
    }
}