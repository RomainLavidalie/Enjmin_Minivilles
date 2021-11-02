namespace Enjmin_Minivilles_Console
{
    public abstract class Cards
    {
        public int diceValue;
        public int cardValue;

        public string cardName;
        public string cardColor;
        public string cardDescription;

        public abstract void Effect(Player player, Player playerThrowingDice);
    }
}