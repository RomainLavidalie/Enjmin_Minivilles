namespace Enjmin_Minivilles_Console
{
    public class Ferme : Cards
    {
        public Ferme()
        {
            cardValue = 1;

            cardName = "Ferme";
            cardColor = "Blue";
            cardDescription = 
                    "Pendant le tour de n'importe quel joueur" +
                    "recevez 1 pièce de la banque.";
        }

        public override void Effect(Player player, Player _)
        {
            player.MoneyBalance++;
        }

        public override bool TestValue(int diceValue)
        {
            return diceValue == 2;
        }
    }
}