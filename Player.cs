using System;
using System.Collections.Generic;

namespace Enjmin_Minivilles_Console
{
    public class Player
    {
        public string name;
        private List<Cards> PlayerCards = new List<Cards>();
        public int MoneyBalance;
        private List<Die> DicePlayed= new List<Die>();

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

        public void Playing(int nbDice, Game G)
        {
            string blue = "Blue";
            string green = "Green";
            string red = "Red";

            for (int i = 0; i < nbDice; i++)
            {
                Die dice = new Die();                
                DicePlayed.Add(dice);
            }
            // joueur B regarde si il peut jouer ses cartes et les joues
            ApplyCardEffect(DicePlayed, G.playerList[G.NextPlayer()], blue, red);

            // joueur A regarde si il peut jouer ses cartes et les joues
            ApplyCardEffect(DicePlayed, this, blue, green);
          
        }

        private void ApplyCardEffect(List<Die> diceList, Player p, string color1, string color2)
        {
            foreach(Cards c in p.PlayerCards)
            {
                foreach(Die d in diceList)
                {
                    if(d.diceValue == c.diceValue && (c.cardColor == color1 || c.cardColor == color2))
                    {
                        Console.WriteLine(c.cardDescription);
                        switch (c.cardColor)
                        {
                            case "Blue":
                            
                                p.MoneyBalance += 1;
                                break;
                            
                            case "Green":
                            
                                p.MoneyBalance += 1;
                                break;
                            case "Red":

                                this.MoneyBalance -= 1;
                                p.MoneyBalance += 1;
                                break;
                        }
                    }
                }
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}