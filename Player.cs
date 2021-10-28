namespace Enjmin_Minivilles_Console
{
    public class Player
    {
        private string name;
        private Cards[] PlayerCards;
        private int MoneyBalance;

        void Player(string name)
        {
            this.name = name;
            PlayerCards = new Cards[];
            MoneyBalance = 3;
        }

        void AddCard(string CardType)
        {
            switch (CardType)
            {
                case Boulangerie:
                    PlayerCards.Add(new Boulangerie());
                    break;
                case Cafe:
                    PlayerCards.Add(new Cafe());
                    break;
                case CDB:
                    PlayerCards.Add(new CDB());
                    break;
                case Ferme:
                    PlayerCards.Add(new Ferme());
                    break;
                case Foret:
                    PlayerCards.Add(new Foret());
                    break;
                case Restaurant:
                    PlayerCards.Add(new Restaurant());
                    break;
                case Stade:
                    PlayerCards.Add(new Stade());
                    break;
                case Superette:
                    PlayerCards.Add(new Superette());
                    break;
            }
        }

        void BuyCard(string CardType)
        {
            PlayerCards.AddCard(CardType);
            Game.Bank[CardType].RemoveCard;
        }
    }
}