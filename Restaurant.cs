namespace Enjmin_Minivilles_Console
{
    public class Restaurant : Cards
    {
        public Restaurant()
        {
        diceValue = 9 & 10;
        cardValue = 3;

        cardName = "Restaurant";
        cardColor = "Red";
        cardDescription = 
                "Recevez 2 pièces du joueur" +
                "qui a lancé les dés.";
        }
    }
}