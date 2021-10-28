using System;
using System.Collections.Generic;

namespace Enjmin_Minivilles_Console
{
    public class Player
    {
        private string name;
        private List<Cards> PlayerCards = new List<Cards>();
        private int MoneyBalance;

        public Player(string name)
        {
            this.name = name;
            PlayerCards = new Cards[];
            MoneyBalance = 3;
        }

        void AddCard(string CardType)
        {
            switch (CardType)
            {
                case "Boulangerie":
                    PlayerCards.Add(new Boulangerie());
                    break;
                case "Café":
                    PlayerCards.Add(new Cafe());
                    break;
                case "Champs de blé":
                    PlayerCards.Add(new CDB());
                    break;
                case "Ferme":
                    PlayerCards.Add(new Ferme());
                    break;
                case "Forêt":
                    PlayerCards.Add(new Foret());
                    break;
                case "Restaurant":
                    PlayerCards.Add(new Restaurant());
                    break;
                case "Stade":
                    PlayerCards.Add(new Stade());
                    break;
                case "Superette":
                    PlayerCards.Add(new Superette());
                    break;
            }
        }

        void BuyCard(string CardType, Game game)
        {
            Player player = new Player(" ");
            player.AddCard(CardType);
            game.Bank[CardType].RemoveCard();
        }
    }
}