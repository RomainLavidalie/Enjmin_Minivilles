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
            while (!Int32.TryParse(Console.ReadLine(), out nbPlayer))
            {
                Console.Write("Mauvais format de réponse veuillez recommencer : ");
            }
            
            Console.WriteLine("Nombre de dés ?");
            while (!Int32.TryParse(Console.ReadLine(), out nbDice))
            {
                Console.Write("Mauvais format de réponse veuillez recommencer : ");
            }

            Game game = new Game(nbPlayer, nbDice);

            Console.WriteLine(game);
        }
    }
}