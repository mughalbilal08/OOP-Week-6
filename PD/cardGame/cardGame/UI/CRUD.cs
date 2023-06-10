using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cardGame.BL;

namespace cardGame.UI
{
    class CRUD
    {
        public static int gameMenu()
        {
            gameHeader();
            Console.WriteLine("\t1. Press to play the game.");
            Console.WriteLine("\t2. Press to exit the game.");
            Console.Write("\t   Enter option  : ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public static void gameHeader()
        {
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\t    **********************    *************     ********************** ");
            Console.WriteLine("\t\t\t  -*-*-*-*-*-*-*-*-*-*-*-   High - Low - Game     -*-*-*-*-*-*-*-*-*-*-*-*-  ");
            Console.WriteLine("\t\t\t    **********************    *************     **********************    ");
            Console.WriteLine("\n\n");
        }
        public static int remaining(cards card1, int remain)
        {
            gameHeader();
            Console.WriteLine("\t*********************************************");
            Console.WriteLine(card1.toString());
            Console.WriteLine("");
            Console.WriteLine("\t*** Reamining Cards *** : " + remain);
            Console.WriteLine("\tEnter 1 if next card is higher");
            Console.WriteLine("\tEnter 2 if next card is lower ");
            Console.Write("\tEnter option : ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public static int gameLose(cards card, int score, bool gamerunnig)
        {
            gameHeader();
            gamerunnig = false;
            Console.WriteLine("\tSORRY YOU LOSE! PRESS ANY KEY TO CONTINUE.");
            Console.WriteLine("\tThe Card was " + card.toString());
            Console.WriteLine("\tYour score is : " + score);
            Console.ReadKey();
            return 0;
        }
        public static int gamewin(bool gamerunnig)
        {
            gameHeader();
            gamerunnig = false;
            Console.WriteLine("\tCongratulations you have scored maximum");
            Console.ReadKey();
            return 0;
        }
    }
}
