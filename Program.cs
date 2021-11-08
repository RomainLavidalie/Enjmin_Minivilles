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
            int nbBot;
            int choixFin;
            
            Console.WriteLine("MINIVILLE");
            Console.WriteLine("Nombre de joueurs ?");
            while (!Int32.TryParse(Console.ReadLine(), out nbPlayer) && nbPlayer < 0)
            {
                Console.Write("Mauvais format de réponse veuillez recommencer : ");
            }
            
            Console.WriteLine("Nombre de dés ?");
            while (!Int32.TryParse(Console.ReadLine(), out nbDice))
            {
                Console.Write("Mauvais format de réponse veuillez recommencer : ");
            }
            
            Console.WriteLine("Nombre de bots ?");
            while (!Int32.TryParse(Console.ReadLine(), out nbBot))
            {
                Console.Write("Mauvais format de réponse veuillez recommencer : ");
            }
            
            Console.WriteLine("Choisissez votre nombre de pièces pour la victoire : 10 (1), 20 (2), 30 (3).");
            while (!Int32.TryParse(Console.ReadLine(), out choixFin) && choixFin > 0 && choixFin < 4)
            {
                Console.Write("Mauvais format de réponse veuillez recommencer : ");
            }

            Game game = new Game(nbPlayer, nbDice, nbBot, choixFin);

            Console.WriteLine(game);
        }
    }
}
