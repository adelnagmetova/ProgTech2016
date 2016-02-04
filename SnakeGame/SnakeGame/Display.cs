using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Display
    {
        public static void display()
        {
            
            Console.SetCursorPosition(5, 3);
            Console.Write("SCORE:" + Snake.score +  "                  " + " LEVEL: " + Wall.lvl);
            

        }
        
    }
}
