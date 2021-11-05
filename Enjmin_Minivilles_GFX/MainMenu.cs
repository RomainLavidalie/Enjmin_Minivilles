using System;
using System.Windows.Forms;

namespace Enjmin_Minivilles_GFX
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void launchGame_Click(object sender, EventArgs e)
        {
            GameWindow c = new GameWindow();
            this.Hide();
            c.ShowDialog();
            this.Close();
        }
    }
}