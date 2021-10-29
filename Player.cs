﻿using System;
using System.Collections.Generic;

namespace Enjmin_Minivilles_Console
{
    public class Player
    {
        public string name;
        private List<Cards> PlayerCards = new List<Cards>();
        private int MoneyBalance;

        public Player(string name)
        {
            this.name = name;
            PlayerCards = new List<Cards>();
            MoneyBalance = 3;
        }

        Cards AddCard(string CardType, Player player)
        {
            switch (CardType)
            {
                case "Boulangerie":
                    Boulangerie boulangerie = new Boulangerie();
                    if(boulangerie.cardValue <= player.MoneyBalance)
                    {
                        PlayerCards.Add(boulangerie);
                        return boulangerie;
                    }
                    else
                    {
                        Console.WriteLine("Vous n'avez pas assez d'argent pour acheter la carte {0}", boulangerie.cardName);
                        return null;
                    }                   
                case "Café":
                    Cafe cafe = new Cafe();
                    if(cafe.cardValue <= player.MoneyBalance)
                    {
                        PlayerCards.Add(cafe);
                        return cafe;
                    }
                    else
                    {
                        Console.WriteLine("Vous n'avez pas assez d'argent pour acheter la carte {0}", cafe.cardName);
                        return null;
                    }
                case "Champs de blé":
                    CDB cdb = new CDB();
                    if(cdb.cardValue <= player.MoneyBalance)
                    {
                        PlayerCards.Add(cdb);
                        return cdb;
                    }
                    else
                    {
                        Console.WriteLine("Vous n'avez pas assez d'argent pour acheter la carte {0}", cdb.cardName);
                        return null;
                    }
                case "Ferme":
                    Ferme ferme = new Ferme();
                    if(ferme.cardValue <= player.MoneyBalance)
                    {
                        PlayerCards.Add(ferme);
                        return ferme;
                    }
                    else
                    {
                        Console.WriteLine("Vous n'avez pas assez d'argent pour acheter la carte {0}", ferme.cardName);
                        return null;
                    }                   
                case "Forêt":
                    Foret foret = new Foret();
                    if(foret.cardValue <= player.MoneyBalance)
                    {
                        PlayerCards.Add(foret);
                        return foret;
                    }
                    else
                    {
                        Console.WriteLine("Vous n'avez pas assez d'argent pour acheter la carte {0}", foret.cardName);
                        return null;
                    }                   
                case "Restaurant":
                    Restaurant restaurant = new Restaurant();
                    if(restaurant.cardValue <= player.MoneyBalance)
                    {
                        PlayerCards.Add(restaurant);
                        return restaurant;
                    }
                    else
                    {
                        Console.WriteLine("Vous n'avez pas assez d'argent pour acheter la carte {0}", restaurant.cardName);
                        return null;
                    }                    
                case "Stade":
                    Stade stade = new Stade();
                    if(stade.cardValue <= player.MoneyBalance)
                    {
                        PlayerCards.Add(stade);
                        return stade;
                    }
                    else
                    {
                        Console.WriteLine("Vous n'avez pas assez d'argent pour acheter la carte {0}", stade.cardName);
                        return null;
                    }                    
                case "Superette":
                    Superette superette = new Superette();
                    if(superette.cardValue <= player.MoneyBalance)
                    {
                        PlayerCards.Add(superette);
                        return superette;
                    }
                    else
                    {
                        Console.WriteLine("Vous n'avez pas assez d'argent pour acheter la carte {0}", superette.cardName);
                        return null;
                    }                   
                default:                   
                    return null;
            }
        }

        void BuyCard(string CardType, Game game, Player player)
        {
            //Player player = new Player(" ");
            
            try
            {
                player.AddCard(CardType, player);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Choose a valid type of card");
            }
            finally
            {
                player.AddCard(CardType, player);
            }
            game.bank[CardType].RemoveCard(AddCard(CardType, player));
        }

    }
}