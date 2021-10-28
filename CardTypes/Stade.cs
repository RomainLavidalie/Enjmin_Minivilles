namespace Enjmin_Minivilles_Console
{
    public class Stade : Cards
    {
        public Stade()
        {
        diceValue = 6;
        cardValue = 6;

        cardName = "Stade";
        cardColor = "Blue";
        cardDescription =
                "Pendant le tour de n'importe quel joueur" +
                "Recevez 4 pièces de la banque.";
        }
    }
}