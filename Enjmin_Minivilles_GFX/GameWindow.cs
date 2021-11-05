using System;
using System.Windows.Forms;

namespace Enjmin_Minivilles_GFX
{
    public partial class GameWindow : Form
    {
        private Game game;
        public GameWindow(Game game)
        {
            InitializeComponent();
            Player1Box.Text = Game._playerList[0].name;
            Player2Box.Text = Game._playerList[1].name;
            Player3Box.Text = Game._playerList[2].name;
            Player4Box.Text = Game._playerList[3].name;
        }
    }
}