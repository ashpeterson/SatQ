using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatQ
{
    class Dev
    {
        /// <summary>
        /// Displayes Title and Calls Intro/About Text from About.txt. Displays basic about and 
        /// licence informaton.
        /// </summary>
        public static void About()
        {
            //Set console text colour for Title
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(String.Format("{0," + Console.WindowWidth * 0.6 + "}", "Shaun and the Quest"));
            //change colour for main text and print from About.txt
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string About = System.IO.File.ReadAllText(@"Recorces\Other\About.txt");
            Console.WriteLine(About);
        }

        /// <summary>
        /// Sets window, buffer, curser size and console title
        /// </summary>
        public static void WindowSet()
        {
            //set window, buffer, cursor size and console title
            Console.Title = "Shaun and the Quest";
            Console.SetWindowSize(90, 30);
            Console.SetBufferSize(90, 30);
            Console.CursorSize = 100;
        }
    }
}
