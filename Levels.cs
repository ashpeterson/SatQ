using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatQ
{
    class Levels
    {
        private static bool GameState;
        private static byte Level;
        private static string LevelText = string.Empty;

        public static void LevelOne()
        {
            GameState = true;
            Level = 1;
            LevelText = System.IO.File.ReadAllText(@"Recorces\Levels\One.txt");
            Console.WriteLine(LevelText);
        }
    }
}
