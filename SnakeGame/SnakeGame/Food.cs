using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    [Serializable]
    class Food : Drawer
    {
        public Food()
        {
            color = ConsoleColor.Green;
            sign = '*';

        }
        public void SetNewPosition()
        {
            body.Clear();
            // int x = new Random().Next(2, 70);// еда будет появляться рандомно в этих пределах по горизонтали
            //int y = new Random().Next(5, 20);// по вертикали

            Game.food.body.Add(new Point (new Random().Next(2, 70), new Random().Next(5, 20) ));

          
            
            
        }

        public static bool FoodinWall()// проверка еды в стене
        {
            foreach(Point p in Game.wall.body)
                if (Game.food.body[0].x == p.x && Game.food.body[0].y == p.y)
                    return true;
            return false;
        }

        public static bool FoodinSnake() //проверка на нахождение еды в внутри змейки
        {
            for(int i=0; i<Game.snake.body.Count; i++)
                if (Game.food.body[0].x == Game.snake.body[i].x && Game.food.body[0].y == Game.snake.body[i].y)
                    return true;
            return false;
        }
        


    }
}
