using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enjmin_Minivilles_GFX
{
    public partial class GameWindow : Form
    {
        private Game game;
        public GameWindow(Game game)
        {
            InitializeComponent();
            this.game = game;
            Player1Box.Text = game._playerList[0].name;
            Player2Box.Text = game._playerList[1].name;
            Player3Box.Text = game._playerList[2].name;
            Player4Box.Text = game._playerList[3].name;
        }

        private async void RollDice_Click(object sender, EventArgs e)
        {
            if (DiceN1.Checked)
            {
                var dice1 = new Die();
                dice1.Tossing();
                Dice1.Image = Properties.Resources.DeThrow;
                Dice2.Image = null;
                await Task.Delay(1000);
                switch (dice1.diceValue)
                {
                    case 1:
                        Dice1.Image = Properties.Resources.De11;
                        break;
                    case 2:
                        Dice1.Image = Properties.Resources.De21;
                        break;
                    case 3:
                        Dice1.Image = Properties.Resources.De31;
                        break;
                    case 4:
                        Dice1.Image = Properties.Resources.De41;
                        break;
                    case 5:
                        Dice1.Image = Properties.Resources.De51;
                        break;
                    case 6:
                        Dice1.Image = Properties.Resources.De61;
                        break;
                }
            }
            
            if (DiceN2.Checked)
            {
                var dice1 = new Die();
                var dice2 = new Die();
                dice1.Tossing();
                dice2.Tossing();
                Dice1.Image = Properties.Resources.DeThrow;
                Dice2.Image = Properties.Resources.DeThrow;
                await Task.Delay(1000);
                switch (dice1.diceValue)
                {
                    case 1:
                        Dice1.Image = Properties.Resources.De11;
                        break;
                    case 2:
                        Dice1.Image = Properties.Resources.De21;
                        break;
                    case 3:
                        Dice1.Image = Properties.Resources.De31;
                        break;
                    case 4:
                        Dice1.Image = Properties.Resources.De41;
                        break;
                    case 5:
                        Dice1.Image = Properties.Resources.De51;
                        break;
                    case 6:
                        Dice1.Image = Properties.Resources.De61;
                        break;
                }
                switch (dice1.diceValue)
                {
                    case 1:
                        Dice2.Image = Properties.Resources.De11;
                        break;
                    case 2:
                        Dice2.Image = Properties.Resources.De21;
                        break;
                    case 3:
                        Dice2.Image = Properties.Resources.De31;
                        break;
                    case 4:
                        Dice2.Image = Properties.Resources.De41;
                        break;
                    case 5:
                        Dice2.Image = Properties.Resources.De51;
                        break;
                    case 6:
                        Dice2.Image = Properties.Resources.De61;
                        break;
                }
            }
        }
    }
}