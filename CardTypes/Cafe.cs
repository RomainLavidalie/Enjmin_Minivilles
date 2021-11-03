using System;

namespace Enjmin_Minivilles_Console
{
    public class Cafe : Cards
    {
        public Cafe()
        {
            cardValue = 2;
            cardName = "Café";
            cardColor = "Red";
            cardDescription = 
                    "Recevez 1 pièce du joueur" +
                    " qui a lancé les dés.";
        }

        public override void Effect(Player player, Player playerThrowingDice)
        {
            player.MoneyBalance++;
            player.MoneyBalance += Math.Min(0, playerThrowingDice.MoneyBalance - 1);
            playerThrowingDice.MoneyBalance = Math.Max(0, playerThrowingDice.MoneyBalance - 1);
            Console.WriteLine(player.MoneyBalance);
        }

        public override bool TestValue(int diceValue)
        {
            return(diceValue == 3);
        }
    }
}