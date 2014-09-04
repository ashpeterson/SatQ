using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SatQ
{
    class Program
    {
        private static string nme = string.Empty;

        public static void Main(string[] args)
        { 
            //Set goto tag, Call about and wait 4 seconds
        Start:
            About();
            System.Threading.Thread.Sleep(4000);

            //Ask user for a name
           AskNme();

            //Test
           Console.WriteLine(nme);
           System.Threading.Thread.Sleep(4000);

            goto Start;

        }

        /// <summary>
        /// Sets console size and Intro/About Text. Displays basic about and 
        /// licence informaton.
        /// </summary>
        static void About()
        {
            Console.SetWindowSize(90, 30);
            Console.Title = "SatQ";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(String.Format("{0," + Console.WindowWidth * 0.6 + "}", "Shaun and the Quest"));
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 1.5 + "}", "Welcome to Shaun and the Quest"));
            Console.WriteLine("This is a simple text based game I'm developing to help improve my programming skills");
            Console.WriteLine("If you have any quesions or wish to help, please dont hesitate to contact me on GitHub");
            Console.WriteLine(String.Format("{0," + Console.WindowWidth * 0.7 + "}", "Published under the GNU v3 License"));
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        /// <summary>
        /// Ask User for charictor name and store it in string "nme"
        /// To be called during a charictor rename event (If ever implimanted)
        /// </summary>
        static void AskNme()
        {
            //Set lable and ask for name
        ChooseName:
            Console.Write("Please enter a carictor name name: ");
            Program.nme = Console.ReadLine();

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