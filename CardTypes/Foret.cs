namespace Enjmin_Minivilles_Console
{
    public class Foret : Cards
    {
        public Foret()
        {
        diceValue = 5;
        cardValue = 3;

        cardName = "Forêt";
        cardColor = "Blue";
        cardDescription = 
                "Pendant le tour de n'importe quel joueur" +
                "Recevez 1 pièce de la banque.";
        }

        public override void Effect(Player player, Player _)
        {
            player.MoneyBalance++;
        }
    }
}