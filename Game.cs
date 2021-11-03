using System;
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
        public int _nbBot;
        private bool playWithOneDie;
        private bool tossingDice;
        public Dictionary<string, Piles> bank = new Dictionary<string, Piles>();
        public List<Player> playerList = new List<Player>();

        public int playerOrder { get; private set; }


        public Game(int nbPlayer, int nbDice, int nbBot)
        {
            _nbPlayer = nbPlayer;
            _nbDice = nbDice;
            _nbBot = nbBot;
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
            PlayerCreation();
            DiceCreation();
            playerOrder = 0;

            tossingDice = false;
            //foreach (Player p in playerList)
            //{
            //    Console.WriteLine(p.name);
            //}

            while(playerList[playerOrder].MoneyBalance < 20)
            {
                Console.WriteLine("{0} à toi de jouer !", playerList[playerOrder].name);
                if(_nbDice>1)
                {
                    //Dice number to play with choice
                    Console.WriteLine($"Veux tu jouer avec un seul dé (1), ou plusieurs ? (2)");
                    int choix;
                    while (!Int32.TryParse(Console.ReadLine(), out choix) || choix > 2 || choix < 1)
                    {
                        Console.Write("Mauvais format de réponse veuillez recommencer : ");
                    }

                    playWithOneDie = (choix == 1);
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
                    int choix;
                    
                    while (!Int32.TryParse(Console.ReadLine(), out choix) || choix > 2 || choix < 1)
                        Console.Write("Mauvais format de réponse veuillez recommencer : ");

                    if (choix == 1)
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
                }
            }

            Console.WriteLine($"Partie terminée, {playerList[playerOrder].name} à gagné !!");
        }

        public int NextPlayer()
        {
            return (playerOrder + 1) % _nbPlayer;
        }
        
        public void PlayerCreation()
        {
            for (int i = 0; i < _nbPlayer; i++)
            {
                string name;
                Console.WriteLine("joueur {0} écrivez votre nom :", i + 1);
                name = Console.ReadLine();

                Player player = new Player(name);

                playerList.Add(player);

            }
        }
        private void DiceCreation()
        {
            foreach (Player player in playerList)
            {
                for (int loop = 0; loop < _nbDice; loop++)
                {
                    player.DicePlayed.Add(new Die());
                }
            }
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

        
        private void Playing(Player playerIsPlaying)
        {
            string green = "Green";
            string red = "Red";

            Player player = playerList[playerOrder];
            Console.WriteLine(playerOrder);
            Console.WriteLine($"{player.name} lance les dés !");
            string[] lignes = new string[5];

            for (int i = 0; i < _nbDice; i++)
            {
                Die dice = player.DicePlayed[i];
                dice.Tossing();
                string[] strings = dice.ToString();
                for (int loop = 0; loop < 5; loop++)
                {
                    lignes[loop] += strings[loop] + " ";
                }
            }
            foreach (string ligne in lignes)
            {
                Console.WriteLine(ligne);
            }
            // joueur B regarde s'il peut jouer ses cartes et les joues
            ApplyCardEffect(player.DicePlayed, playerList[NextPlayer()], red);

            // joueur A regarde s'il peut jouer ses cartes et les joues
            ApplyCardEffect(player.DicePlayed, player, green);
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

        private void CardEffect(Cards c, Die d, Player p, string color)
        {
            if(c.TestValue(d.diceValue) && (c.cardColor == color || c.cardColor == "Blue"))
            {
                Console.WriteLine($"{p.name} : {c.cardDescription}");   //Debug
                Console.WriteLine($"{p.name}, {color}");                //Debug
                c.Effect(p,playerList[playerOrder]);
            }
        }

        public override string ToString()
        {
            Partie();
            return base.ToString();
        }

    }
}
