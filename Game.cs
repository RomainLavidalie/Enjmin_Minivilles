﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enjmin_Minivilles_Console
{
    class Game
    {
        private int _nbPlayer;
        private int _nbDice;
        public Dictionary<string, Piles> bank = new Dictionary<string, Piles>();
        

        public Game(int nbPlayer, int nbDice)
        {
            _nbPlayer = nbPlayer;
            _nbDice = nbDice;
          
        }


        public void Bank()
        {
            Boulangerie boulangerieCard = new Boulangerie();
            Cafe cafeCard = new Cafe();
            CDB cdbCard = new CDB();
            Ferme fermeCard = new Ferme();
            Foret foretCard = new Foret();
            Restaurant restaurantCard = new Restaurant();
            Stade stadeCard = new Stade();
            Superette superetteCard = new Superette();

            Piles boulangerie = new Piles(boulangerieCard, 4);
            Piles cafe = new Piles(cafeCard, 4);
            Piles cdb = new Piles(cdbCard, 4);
            Piles ferme = new Piles(fermeCard, 4);
            Piles foret = new Piles(foretCard, 4);
            Piles restaurant = new Piles(restaurantCard, 4);
            Piles stade = new Piles(stadeCard, 4);
            Piles superette = new Piles(superetteCard, 4);

            bank.Add("Boulangerie", boulangerie);
            bank.Add("Café", cafe);
            bank.Add("Champs de blé", cdb);
            bank.Add("Ferme", ferme);
            bank.Add("Forêt", foret);
            bank.Add("Restaurant", restaurant);
            bank.Add("Stade", stade);
            bank.Add("Superette", superette);
        }


        public void Partie()
        {
            
            Console.ReadLine();
        }

    }
}
