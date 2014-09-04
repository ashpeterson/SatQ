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
        public static void Main(string[] args)
        {
            //Set goto tag, Call about and wait 2 seconds
        Start:
            Dev.WindowSet();
            Dev.About();
            System.Threading.Thread.Sleep(2000);
            //Ask user for a name
            Char.AskNme();

            //clear console for level Text
            Console.Clear();
            
            //Test Level text one
            Levels.LevelOne();

            goto Start;
        }
    }
}