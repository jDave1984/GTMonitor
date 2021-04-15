using System;
using System.Windows.Forms;
using GTM.app.Game;

namespace GTM.app
{
    public partial class MainForm : Form
    {
        private readonly string defaultFolder =
            @"X:\Games\SteamLibrary\steamapps\common\Grand Tactician The Civil War (1861-1865)";

        public MainForm()
        {
            GameConnection.RootFolder =
                @"X:\Games\SteamLibrary\steamapps\common\Grand Tactician The Civil War (1861-1865)";
            InitializeComponent();
            GameFolder.Text = GameConnection.RootFolder;
        }

        private void LastSaveButton_Click(object sender, EventArgs e)
        {
            LastSaveFile.Text = GameConnection.GetLastSave();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            // Load MilitaryGroups, Regiments, etc.
            var groups = GameConnection.GetGroups();
            var commanders = GameConnection.GetCommanders();
            var regiments = GameConnection.GetRegiments();
        }

        private void FolderButton_Click(object sender, EventArgs e)
        {
            using (var folderForm = new FolderBrowserDialog())
            {
                folderForm.ShowDialog();
                if (!string.IsNullOrWhiteSpace(folderForm.SelectedPath))
                {
                    GameConnection.RootFolder = folderForm.SelectedPath;
                    GameFolder.Text = GameConnection.RootFolder;
                }
                else
                {
                    GameConnection.RootFolder = defaultFolder;
                    GameFolder.Text = defaultFolder;
                }
            }
        }
    }
}