namespace Enjmin_Minivilles_GFX
{
    public abstract class Cards
    {
        public int cardValue;

        public string cardName;
        public string cardColor;
        public string cardDescription;

        public abstract void Effect(Player player, Player playerThrowingDice);
        public abstract bool TestValue(int diceValue);
    }
}