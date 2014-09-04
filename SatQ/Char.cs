using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatQ
{
    class Char
    {
        private static string nme = string.Empty;

        /// <summary>
        /// Ask User for charictor name and store it in string "nme"
        /// To be called during a charictor rename event (If ever implimanted)
        /// </summary>
        public static void AskNme()
        {
        //Set lable and ask for name
        ChooseName:
            Console.Write("Please enter your character name: ");
            Char.nme = Console.ReadLine();

            //Comfirm username then convert anwnser to lower, Set invalid entry lable
        Invalid:
            Console.Write("Are you sure you want to use {0} for your name, Y or N: ", nme);
            string YesNo = Console.ReadLine().ToLower();

            // If yes then carry on
            if (YesNo == "yes" || YesNo == "y")
            {
                Console.WriteLine("Welcome {0} to the relm of Stullurnme", nme);
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
