namespace Enjmin_Minivilles_Console
{
    public class Superette : Cards
    {
        public Superette()
        {
        diceValue = 4;
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
    }
}