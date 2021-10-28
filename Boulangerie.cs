namespace Enjmin_Minivilles_Console
{
    public class Boulangerie : Cards
    {
        public Boulangerie()
        {
        diceValue = 2 & 3;
        cardValue = 1;

        cardName = "Boulangerie";
        cardColor = "Green";
        cardDescription = 
                "Uniquement pendant votre tour" +
                "Recevez 1 pièces de la banque";
        }
    }
}