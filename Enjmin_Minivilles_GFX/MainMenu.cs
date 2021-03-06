using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Enjmin_Minivilles_GFX
{
    public partial class MainMenu : Form
    {
        private List<Player> playerList = new List<Player>();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void launchGame_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(playerName1.Text))
            {
                var player = new Player(playerName1.Text);
                playerList.Add(player);
            }
                
            if (!String.IsNullOrEmpty(playerName2.Text))
                playerList.Add(new Player(playerName2.Text));
            if (!String.IsNullOrEmpty(playerName3.Text))
                playerList.Add(new Player(playerName3.Text));
            if (!String.IsNullOrEmpty(playerName4.Text))
                playerList.Add(new Player(playerName4.Text));

            Game game = new Game(playerList, playerList.Count, 2, 0);
            GameWindow c = new GameWindow(game);
            this.Hide();
            c.ShowDialog();
            this.Close();
        }
    }
}