namespace Enjmin_Minivilles_GFX
{
    public class Boulangerie : Cards
    {
        public Boulangerie()
        {
            cardValue = 1;
            cardName = "Boulangerie";
            cardColor = "Green";
            cardDescription = 
                    "Uniquement pendant votre tour" +
                    " Recevez 1 pièces de la banque";
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
            return (diceValue == 2 || diceValue == 3);
        }
    }
}