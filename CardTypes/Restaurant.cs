using System;

namespace Enjmin_Minivilles_Console
{
    public class Restaurant : Cards
    {
        public Restaurant()
        {
            cardValue = 3;

            cardName = "Restaurant";
            cardColor = "Red";
            cardDescription = 
                    "Recevez 2 pièces du joueur" +
                    "qui a lancé les dés.";
        }

        public override void Effect(Player player, Player playerThrowingDice)
        {
            player.MoneyBalance += 2;
            player.MoneyBalance += Math.Min(0, playerThrowingDice.MoneyBalance - 2);
            playerThrowingDice.MoneyBalance = Math.Max(0, playerThrowingDice.MoneyBalance - 2);
        }
        public override void Effect(AI ai, Player playerThrowingDice)
        {
            ai.MoneyBalance += 2;
            ai.MoneyBalance += Math.Min(0, playerThrowingDice.MoneyBalance - 2);
            playerThrowingDice.MoneyBalance = Math.Max(0, playerThrowingDice.MoneyBalance - 2);
        }

        public override bool TestValue(int diceValue)
        {
            return diceValue == 5;
        }
    }
}