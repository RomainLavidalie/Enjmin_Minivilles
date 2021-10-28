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

        Cards AddCard(string CardType)
        {
            switch (CardType)
            {
                case "Boulangerie":
                    Boulangerie boulangerie = new Boulangerie();
                    PlayerCards.Add(boulangerie);
                    return boulangerie;
                case "Café":
                    Cafe cafe = new Cafe();
                    PlayerCards.Add(cafe);
                    return cafe;
                case "Champs de blé":
                    CDB cdb = new CDB();
                    PlayerCards.Add(cdb);
                    return cdb;
                case "Ferme":
                    Ferme ferme = new Ferme();
                    PlayerCards.Add(ferme);
                    return ferme;
                case "Forêt":
                    Foret foret = new Foret();
                    PlayerCards.Add(foret);
                    return foret;
                case "Restaurant":
                    Restaurant restaurant = new Restaurant();
                    PlayerCards.Add(restaurant);
                    return restaurant;
                case "Stade":
                    Stade stade = new Stade();
                    PlayerCards.Add(stade);
                    return stade;
                case "Superette":
                    Superette superette = new Superette();
                    PlayerCards.Add(superette);
                    return superette;
            }
        }

        void BuyCard(string CardType, Game game)
        {
            Player player = new Player(" ");
            player.AddCard(CardType);
            game.bank[CardType].RemoveCard(AddCard(CardType));
        }
    }
}