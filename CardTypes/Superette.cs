namespace Enjmin_Minivilles_Console
{
    public class Superette : Cards
    {
        public Superette()
        {
            cardValue = 2;

            cardName = "Supérette";
            cardColor = "Green";
            cardDescription = 
                    "Uniquement pendant votre tour" +
                    "Recevez 3 pièces de la banque";
        }

        public override void Effect(Player player, Player playerThrowingDice)
        {
            player.MoneyBalance += 3;
        }

        public override bool TestValue(int diceValue)
        {
            return diceValue == 4;
        }
    }
}