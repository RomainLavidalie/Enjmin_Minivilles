namespace Enjmin_Minivilles_Console
{
    public class Stade : Cards
    {
        public Stade()
        {
            cardValue = 6;

            cardName = "Stade";
            cardColor = "Blue";
            cardDescription =
                    "Pendant le tour de n'importe quel joueur" +
                    "Recevez 4 pièces de la banque.";
        }

        public override void Effect(Player player, Player playerThrowingDice)
        {
            player.MoneyBalance += 4;
        }

        public override bool TestValue(int diceValue)
        {
            return diceValue == 6;
        }
    }
}