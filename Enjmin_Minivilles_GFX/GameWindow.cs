using System;
using System.Windows.Forms;

namespace Enjmin_Minivilles_GFX
{
    public partial class GameWindow : Form
    {
        public GameWindow()
        {
            Game game = new Game();
            InitializeComponent();
        }
    }
}