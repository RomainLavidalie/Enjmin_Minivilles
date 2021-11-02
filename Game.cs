﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enjmin_Minivilles_Console
{
    public class Game
    {
        public int _nbPlayer;
        public int _nbDice;
        public Dictionary<string, Piles> bank = new Dictionary<string, Piles>();
        public List<Player> playerList = new List<Player>();

        public int playerOrder { get; private set; }


        public Game(int nbPlayer, int nbDice)
        {
            _nbPlayer = nbPlayer;
            _nbDice = nbDice;
            Bank();
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
            PlayerCreation(_nbPlayer);
            playerOrder = 0;

            foreach (Player p in playerList)
            {
                Console.WriteLine(p.name);
            }

            while(true)
            {
                Console.WriteLine("{0} à toi de jouer !", playerList[playerOrder].name);
                Console.WriteLine("{0} veux-tu acheter une carte (1), ou passer ton tour ? (2)", playerList[playerOrder].name);
                int choix;
                while (!Int32.TryParse(Console.ReadLine(), out choix) || choix > 2 || choix < 1)
                {
                    Console.Write("Mauvais format de réponse veuillez recommencer : ");
                }
                if(choix == 1)
                {
                    PlayerChoice(playerList[playerOrder]);
                    continue;
                }
                else
                {
                    playerOrder = NextPlayer();
                }
                Console.ReadLine();
            }
        }

        public int NextPlayer()
        {
            return (playerOrder + 1) % _nbPlayer;
        }
        
        public void PlayerCreation(int nb)
        {
            for (int i = 0; i < nb; i++)
            {
                string name;
                Console.WriteLine("joueur {0} écrivez votre nom :", i + 1);
                name = Console.ReadLine();

                Player player = new Player(name);

                playerList.Add(player);

            }
        }

        public void PlayerChoice(Player p)
        {
            //Game G = new Game(_nbPlayer, _nbDice);
            string colourChoice;
            Console.WriteLine("Choisi ton type de carte.");
            colourChoice = Console.ReadLine();
            p.BuyCard(colourChoice, this, p);
        }

        
        private void Playing()
        {
            string blue = "Blue";
            string green = "Green";
            string red = "Red";

            Player player = playerList[playerOrder];
            
            string[] lignes = new string[5];

            for (int i = 0; i < _nbDice; i++)
            {
                Die dice = new Die(); 
                string[] strings = dice.ToString();
                for (int loop = 0; loop < 5; loop++)
                {
                    lignes[loop] += strings[loop] + " ";
                }
                player.DicePlayed.Add(dice);
            }
            foreach (string ligne in lignes)
            {
                Console.WriteLine(ligne);
            }
            // joueur B regarde s'il peut jouer ses cartes et les joues
            ApplyCardEffect(player.DicePlayed, playerList[NextPlayer()], blue, red);

            // joueur A regarde s'il peut jouer ses cartes et les joues
            ApplyCardEffect(player.DicePlayed, player, blue, green);
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
                                p.MoneyBalance -= 1;
                                p.MoneyBalance += 1;
                                break;
                        }
                    }
                }
            }
        }
       

        public override string ToString()
        {
            Partie();
            return base.ToString();
        }

    }
}
