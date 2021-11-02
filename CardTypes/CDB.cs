namespace Enjmin_Minivilles_Console
{
    public class CDB : Cards
    {
        public CDB()
        {
            cardValue = 1;

            cardName = "Champs de blé";
            cardColor = "Blue";
            cardDescription = 
                    "Pendant le tour de n'importe quel joueur" +
                    "Recevez 1 pièce de la banque.";
        }

        public override void Effect(Player player, Player _)
        {
            player.MoneyBalance++;
        }

        public override bool TestValue(int diceValue)
        {
            return (diceValue == 1);
        }
    }
}