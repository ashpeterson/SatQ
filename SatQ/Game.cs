using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SatQ
{
    class Game
    {
        private static string nme = string.Empty;

        public static void Main(string[] args)
        { 
            //Set goto tag, Call about and wait 4 seconds
        Start:
            About();
            System.Threading.Thread.Sleep(2000);
            //Ask user for a name
            AskNme();

            Levels.LevelOne();

            goto Start;
        }

        /// <summary>
        /// Sets console size, Curser size and calls Intro/About Text from About.txt. Displays basic about and 
        /// licence informaton.
        /// </summary>
        static void About()
        {
            //set window and cursor size
            Console.SetWindowSize(90, 30);
            Console.CursorSize = 100;
            //set console title, colour for Title and print title to console
            Console.Title = "SatQ";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(String.Format("{0," + Console.WindowWidth * 0.6 + "}", "Shaun and the Quest"));
            //change colour for main text and print from About.txt
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string About = System.IO.File.ReadAllText(@"Recorces\Other\About.txt");
            Console.WriteLine(About);
        }

        /// <summary>
        /// Ask User for charictor name and store it in string "nme"
        /// To be called during a charictor rename event (If ever implimanted)
        /// </summary>
        static void AskNme()
        {
            //Set lable and ask for name
        ChooseName:
            Console.Write("Please enter your character name: ");
            Game.nme = Console.ReadLine();

            //Comfirm username then convert anwnser to lower, Set invalid entry lable
        Invalid:
            Console.Write("Are you sure you want to use {0} for your name, Y or N: ", nme);
            string YesNo = Console.ReadLine().ToLower();

            // If yes then carry on
            if (YesNo == "yes" || YesNo == "y")
            {
                Console.WriteLine("Welcome {0} to the relm of Shaun", nme);
            }

            //If no then goto "ChooseName"
            else if (YesNo == "no" || YesNo == "n")
            {
                goto ChooseName;
            }

            // If invalid keypress goto "Invalid"
            else
            {
                Console.WriteLine("Please enter Y or N");
                goto Invalid;
            }

        }

    }
}