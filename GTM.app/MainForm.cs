using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GTM.app.Game;

namespace GTM.app
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            GameConnection.RootFolder =
                @"X:\Games\SteamLibrary\steamapps\common\Grand Tactician The Civil War (1861-1865)";
            InitializeComponent();
            this.GameFolder.Text = GameConnection.RootFolder;
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            var lastSaveFilePath = GameConnection.GetLastSave();
            MessageBox.Show(lastSaveFilePath);
        }
    }
}