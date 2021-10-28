namespace Enjmin_Minivilles_Console
{
    public class Cafe : Cards
    {
        public Cafe()
        {
        diceValue = 3;
        cardValue = 2;

        cardName = "Café";
        cardColor = "Red";
        cardDescription = 
                "Recevez 1 pièce du joueur" +
                "qui a lancé les dés.";
        }
    }
}