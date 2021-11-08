﻿using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enjmin_Minivilles_GFX
{
    public class Game
    {
        public int _nbPlayer;
        public List<Player> _playerList;
        public int _nbDice;
        public int _nbBot;
        private bool playWithOneDie;
        private bool tossingDice;
        public Dictionary<string, Piles> bank = new Dictionary<string, Piles>();
        public List<Player> playerList = new List<Player>();
        public List<AI> aIList = new List<AI>();
        public static Random Random;

        public int playerOrder { get; private set; }
        public int aIOrder { get; private set; }


        public Game(List<Player> listPlayer, int nbPlayer, int nbDice, int nbBot)
        {
            _nbPlayer = nbPlayer;
            _playerList = listPlayer;
            _nbDice = nbDice;
            _nbBot = nbBot;
            Bank();
            Random = new Random();
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


        public void Partie(){
            
        playerOrder = 0;

            tossingDice = false;

            while(playerList[playerOrder].MoneyBalance < 20 || aIList[aIOrder].MoneyBalance < 20)
            {
                Console.WriteLine("{0} à toi de jouer !", playerList[playerOrder].name);
                if(_nbDice>1)
                {
                    //Dice number to play with choice
                    Console.WriteLine($"Veux tu jouer avec un seul dé (1), ou plusieurs ? (2)");
                    int choice;
                    while (!Int32.TryParse(Console.ReadLine(), out choice) || choice > 2 || choice < 1)
                    {
                        Console.Write("Mauvais format de réponse veuillez recommencer : ");
                    }

                    playWithOneDie = (choice == 1);
                }
                if (!tossingDice)
                {
                    Playing(playerList[playerOrder]);
                    tossingDice = true;
                }

                {

                    //Card buying choice
                    Console.WriteLine("{0} veux-tu acheter une carte (1), ou passer ton tour ? (2)",
                        playerList[playerOrder].name);
                    
                    Console.WriteLine("Tu as {0} pieces", playerList[playerOrder].MoneyBalance);
                    int choice;
                    
                    while (!Int32.TryParse(Console.ReadLine(), out choice) || choice > 2 || choice < 1)
                        Console.Write("Mauvais format de réponse veuillez recommencer : ");

                    if (choice == 1)
                    {
                        PlayerChoice(playerList[playerOrder]);
                        continue;
                    }
                    else
                    {
                        //Playing(playerList[playerOrder]);
                        Console.ReadLine();
                        playerOrder = NextPlayer();
                        tossingDice = false;
                    }

                    Thread.Sleep(1000);
                    if(_nbBot < 1)
                    {
                        continue;
                    }
                    else
                    {

                        AIPlaying(aIList[aIOrder]);
                        int aiChoice;
                        aiChoice = Random.Next(0, 2);

                        if(aiChoice == 1)
                        {                       
                            aIList[aIOrder].BuyCard(this, aIList[aIOrder]);
                            aIOrder = NextAI();
                        }
                        else
                        {
                            aIOrder = NextAI();
                        }
                        Thread.Sleep(1000);
                    }
                }


            }

            if(playerList[playerOrder].MoneyBalance >= 20)
            {
                Console.WriteLine($"Partie terminée, {playerList[playerOrder].name} à gagné !!");
            }else if(aIList[aIOrder].MoneyBalance >= 20)
            {                
                Console.WriteLine($"Partie terminée, l'ordinateur {aIOrder} à gagné !!");
            }

        }

        public int NextPlayer()
        {
            return (playerOrder + 1) % _nbPlayer;
        }
        public int NextAI()
        {
            return (aIOrder + 1) % _nbBot;
        }

        public void PlayerChoice(Player p)
        {
            //Game G = new Game(_nbPlayer, _nbDice);
            string colourChoice;
            Console.WriteLine("Choisi ton type de carte.");
            colourChoice = Console.ReadLine();
            p.BuyCard(colourChoice, this, p);
            Console.WriteLine("Tu as {0} pieces", p.MoneyBalance);
        }

        
        private void Playing(Player playerIsPlaying) // pas sur de garder le paramètre AI
        {
            string green = "Green";
            string red = "Red";

            Player player = playerList[playerOrder];
            Console.WriteLine(playerOrder);
            Console.WriteLine($"{player.name} lance les dés !");
            string[] lignes = new string[5];
            

            // joueur B regarde s'il peut jouer ses cartes et les joues
            ApplyCardEffect(player.DicePlayed, playerList[NextPlayer()], red);

            // joueur A regarde s'il peut jouer ses cartes et les joues
            ApplyCardEffect(player.DicePlayed, player, green);
        }

        private void AIPlaying(AI ai)
        {
            string green = "Green";
            string red = "Red";

            int aiNumber = aIList.IndexOf(ai);
            Console.WriteLine($"L'ordinateur {aiNumber} lance les dés !"); // Faire en sorte que l'ordi entre dans l'ordre des joueurs
            string[] lignes = new string[5];

            ApplyCardEffect(ai.DicePlayed, aIList[NextAI()], red);
            ApplyCardEffect(ai.DicePlayed, ai, green);

            Console.WriteLine($"L'ordinateur {aiNumber} à {ai.MoneyBalance} pièces");
        }

        private void ApplyCardEffect(List<Die> diceList, Player p, string color)
        {
            foreach(Cards c in p.PlayerCards)
            {
                if(playWithOneDie)
                    CardEffect(c,diceList[0],p,color);
                else
                    foreach(Die d in diceList)
                        CardEffect(c,d,p,color);
            }
        }
        private void ApplyCardEffect(List<Die> diceList, AI ai, string color)
        {
            foreach(Cards c in ai.AiCards)
            {
                if(playWithOneDie)
                    CardEffect(c,diceList[0],ai,color);
                else
                    foreach(Die d in diceList)
                        CardEffect(c,d,ai,color);
            }
        }

        private void CardEffect(Cards c, Die d, Player p, string color)
        {
            if(c.TestValue(d.diceValue) && (c.cardColor == color || c.cardColor == "Blue"))
            {
                Console.WriteLine($"{p.name} : {c.cardDescription}");   //Debug
                Console.WriteLine($"{p.name}, {color}");                //Debug
                c.Effect(p,playerList[playerOrder]);
            }
        }
        private void CardEffect(Cards c, Die d, AI ai, string color)
        {
            if(c.TestValue(d.diceValue) && (c.cardColor == color || c.cardColor == "Blue"))
            {
                Console.WriteLine($"Ordinateur : {c.cardDescription}");   //Debug
                Console.WriteLine($"Ordinateur , {color}");                //Debug
                c.Effect(ai, playerList[playerOrder]);
            }
        }

        public override string ToString()
        {
            Partie();
            return base.ToString();
        }

    }
}
