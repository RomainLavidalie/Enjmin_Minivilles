using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Enjmin_Minivilles_Console
{
    public class Player
    {
        public string name;
        public List<Cards> PlayerCards { get; private set; } = new List<Cards>();
        public int MoneyBalance;
        public List<Die> DicePlayed= new List<Die>();

        public Player(string name)
        {
            this.name = name;
            PlayerCards = new List<Cards>();
            MoneyBalance = 3;
        }

        private void AddCard(Cards card, Game game, string CardType)
        {
            if(card.cardValue <= MoneyBalance)
            {
                PlayerCards.Add(card);
                MoneyBalance -= card.cardValue;
                game.bank[CardType].RemoveCard(GetCard(CardType));
            }
            else
            {
                Console.WriteLine($"Vous n'avez pas assez d'argent pour acheter la carte {card.cardName}");
            }       
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
                    Superette superette = new Superette();
                    return new Superette();
                default:                   
                    return null;
            }
        }

        public void BuyCard(string CardType, Game game, Player player)
        {
            //Player player = new Player(" ");
            while (true)
            {
                try
                {
                    Cards card = player.GetCard(CardType);
                    player.AddCard(card, game, CardType);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Choose a valid type of card");
                }
            }
        }
        
        public override string ToString()
        {
            return base.ToString();
        }
    }
}