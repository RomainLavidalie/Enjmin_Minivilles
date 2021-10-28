using System;
using System.Collections.Generic;

namespace Enjmin_Minivilles_Console
{
    internal class Program
    {
        public static List<Player> playerList = new List<Player>();
        public static void Main(string[] args)
        {
            int nbPlayer;
            int nbDice;

            

            Console.WriteLine("MINIVILLE");
            Console.WriteLine("Nombre de joueurs ?");
            nbPlayer = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Nombre de déw ?");
            nbDice = Int32.Parse(Console.ReadLine());

            PlayerCreation(nbPlayer);

            foreach (Player p in playerList)
            {
                Console.WriteLine(p);
            }
            Console.ReadLine();
            Game game = new Game(nbPlayer, nbDice);

            Console.WriteLine(game);
            //Console.ReadLine();
        }

        public static void PlayerCreation(int nb)
        {
            for(int i = 0; i < nb; i++)
            {
                string name;
                Console.WriteLine("joueur {0} écrivez votre nom :", i+1);
                name = Console.ReadLine();

                Player player = new Player(name);

                playerList.Add(player);
                
            }
        }
    }
}