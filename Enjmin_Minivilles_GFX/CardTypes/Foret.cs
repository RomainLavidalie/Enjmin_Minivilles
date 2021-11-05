namespace Enjmin_Minivilles_GFX
{
    public class Foret : Cards
    {
        public Foret()
        {
            cardValue = 3;

            cardName = "Forêt";
            cardColor = "Blue";
            cardDescription = 
                    "Pendant le tour de n'importe quel joueur" +
                    " Recevez 1 pièce de la banque.";
        }

        public override void Effect(Player player, Player _)
        {
            player.MoneyBalance++;
        }
        public override void Effect(AI ai, Player _)
        {
            ai.MoneyBalance++;
        }

        public override bool TestValue(int diceValue)
        {
            return diceValue == 5;
        }
    }
}