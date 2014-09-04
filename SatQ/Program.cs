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
        public static void Main(string[] args)
        {
        Start:
            About();
            System.Threading.Thread.Sleep(3000);
            goto Start;

        }

        /// <summary>
        /// Sets console size and Intro/About Text
        /// </summary>
        static void About()
        {
            Console.SetWindowSize(90, 30);
            Console.Title = "SatQ";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(String.Format("{0," + Console.WindowWidth * 0.6 + "}", "Shaun and the Quest"));
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 1.5 + "}", "Welcome to Shaun and the Quest"));
            Console.WriteLine("This is a simple text based game I'm developing to help improve my programming skills");
            Console.WriteLine("If you have any quesions or wish to help, please dont hesitate to contact me on GitHub");
            Console.WriteLine(String.Format("{0," + Console.WindowWidth * 0.7 + "}", "Published under the GNU v3 License"));
        }

    }
}