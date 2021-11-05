using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enjmin_Minivilles_GFX
{
    public class AI
    {
        public List<Cards> AiCards { get; private set; } = new List<Cards>();
        public List<Die> DicePlayed = new List<Die>();
        public int MoneyBalance;
        private static Random random;
        private string[] CardTab = new string[8] { "Boulangerie", "Café", "Champs de blé", "Ferme", "Forêt", "Restaurant", "Stade", "Superette" };


        public AI()
        {
            AiCards = new List<Cards>();
            MoneyBalance = 3;
            random = new Random();
        }

        private void AddCard(Cards card, Game game, string CardType)
        {
            AiCards.Add(card);
            MoneyBalance -= card.cardValue;
            game.bank[CardType].RemoveCard(GetCard(CardType));
            Console.WriteLine($"l'ordinateur a acheté la carte {CardType}");       
        }

        Cards GetCard(string CardType)
        {
            switch (CardType)
            {
                case "Boulangerie":
                    return new Boulangerie();
                case "Café":
                    return new Cafe();
                case "Champs de blé":
                    return new CDB();
                case "Ferme":
                    return new Ferme();
                case "Forêt":
                    return new Foret();
                case "Restaurant":
                    return new Restaurant();
                case "Stade":
                    return new Stade();
                case "Superette":
                    return new Superette();
                default:
                    return null;
            }
        }

        public void BuyCard(Game game, AI ai)
        {
            while (true)
            {
                int cardIndex = random.Next(0, CardTab.Length);
                string CardType = CardTab[cardIndex];
                Cards card = ai.GetCard(CardType); 
                if(card.cardValue <= MoneyBalance)
                {
                    ai.AddCard(card, game, CardType);
                    break;
                }
            }

        }
    }
}
