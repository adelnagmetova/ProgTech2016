using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Food : Drawer
    {
        public Food()
        {
            color = ConsoleColor.Green;
            sign = '*';

        }
        public void SetNewPosition()
        {
            int x = new Random().Next(2, 70);
            int y = new Random().Next(5, 20);
           // int x = 2, y = 20;

            if (body.Count == 0)
                body.Add(new Point(x, y));
            else
            {
                body[0].x = x;
                body[0].y = y;
            }
            
        }
        public static bool FoodinSnake()
        {
            foreach (Point p in Game.snake.body)
                if (Game.snake.body[0].x == p.x && Game.snake.body[0].y == p.y)
                    return false;
            return true;
        }


    }
}
