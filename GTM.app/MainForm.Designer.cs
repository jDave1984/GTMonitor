namespace GTM.app
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
            this.LastSaveButton = new System.Windows.Forms.Button();
            this.LastSaveFile = new System.Windows.Forms.Label();
            this.LoadButton = new System.Windows.Forms.Button();
            this.FolderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameFolder
            // 
            this.GameFolder.Location = new System.Drawing.Point(121, 9);
            this.GameFolder.Name = "GameFolder";
            this.GameFolder.Size = new System.Drawing.Size(667, 23);
            this.GameFolder.TabIndex = 0;
            this.GameFolder.Text = "label1";
            // 
            // LastSaveButton
            // 
            this.LastSaveButton.Location = new System.Drawing.Point(12, 35);
            this.LastSaveButton.Name = "LastSaveButton";
            this.LastSaveButton.Size = new System.Drawing.Size(103, 23);
            this.LastSaveButton.TabIndex = 1;
            this.LastSaveButton.Text = "Get Last Save";
            this.LastSaveButton.UseVisualStyleBackColor = true;
            this.LastSaveButton.Click += new System.EventHandler(this.LastSaveButton_Click);
            // 
            // LastSaveFile
            // 
            this.LastSaveFile.Location = new System.Drawing.Point(121, 35);
            this.LastSaveFile.Name = "LastSaveFile";
            this.LastSaveFile.Size = new System.Drawing.Size(667, 23);
            this.LastSaveFile.TabIndex = 2;
            this.LastSaveFile.Text = "label1";
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(12, 64);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 3;
            this.LoadButton.Text = "Monitor";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // FolderButton
            // 
            this.FolderButton.Location = new System.Drawing.Point(12, 6);
            this.FolderButton.Name = "FolderButton";
            this.FolderButton.Size = new System.Drawing.Size(103, 23);
            this.FolderButton.TabIndex = 4;
            this.FolderButton.Text = "Select Folder";
            this.FolderButton.UseVisualStyleBackColor = true;
            this.FolderButton.Click += new System.EventHandler(this.FolderButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FolderButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.LastSaveFile);
            this.Controls.Add(this.LastSaveButton);
            this.Controls.Add(this.GameFolder);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grant Tactician Monitor";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button FolderButton;

        private System.Windows.Forms.Button LoadButton;

        private System.Windows.Forms.Button LastSaveButton;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label LastSaveFile;

        private System.Windows.Forms.Button TestButton;

        private System.Windows.Forms.Label GameFolder;

        #endregion
    }
}