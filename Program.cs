using System;
using System.Collections.Generic;

namespace Enjmin_Minivilles_Console
{
    internal class Program
    {
        //public static List<Player> playerList = new List<Player>();
        public static void Main(string[] args)
        {
            int nbPlayer;
            int nbDice;



            Console.WriteLine("MINIVILLE");
            Console.WriteLine("Nombre de joueurs ?");
            nbPlayer = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Nombre de dés ?");
            nbDice = Int32.Parse(Console.ReadLine());

            Game game = new Game(nbPlayer, nbDice);

            Console.WriteLine(game);
        }
    }
}