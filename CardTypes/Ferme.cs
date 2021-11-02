namespace Enjmin_Minivilles_Console
{
    public class Ferme : Cards
    {
        public Ferme()
        {
        diceValue = 2;
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
    }
}