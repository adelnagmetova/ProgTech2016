using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    [Serializable]
    class Snake: Drawer
    {
        
        public static int score = 0;// создаем переменную для очков
        public Snake()
        {
            color = ConsoleColor.White;
            sign = 'o';
            body.Add(new Point(10, 10));
           
        }
 
    
        public void move(int dx, int dy)// функция для движения змейки
        {
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;// каждый следующий элемент будет наследовать информацию от предыдущего
                body[i].y = body[i - 1].y;
            }
            body[0].x += dx;// голова получает направление по координатам
            body[0].y += dy;

            if (body[0].x == -1) Game.EndGame(); // обозначаем конец игры, если змейка выходит за пределы консоли
            if (body[0].y == -1) Game.EndGame();
            if (body[0].x == 71) Game.EndGame();
            if (body[0].y == 31) Game.EndGame();
        
            if (SnakeinSnake() == true)// конец игры, если змейка натыкается на себя
            {
                Game.GameOver = true;
                Game.EndGame();
            }
            if (CollisionWithWall() == true) // конец игры, если змейка сталкивается со стеной
            {
                Game.GameOver = true;
                Game.EndGame();
            }
            if (body[0].x == Game.food.body[0].x &&// проверка съедает ли змейка еду
                body[0].y == Game.food.body[0].y)
            {
                body.Add(new Point(0, 0));// если съедает, то переходит на следующее место
                

                Game.food.SetNewPosition();
                while(Food.FoodinSnake() == true || Food.FoodinWall() == true)
                {
                    Game.food.SetNewPosition();
                }
                score++;// добавляюся очки

                if (score % 3 == 0)// после того как наберешь 3 очка - новый уровень
                {
                    Game.snake.body.Clear(); // змейка уменьшается
                    Game.wall.Level(++Wall.lvl);//загружается новый уровень
                    SnakeNewPosition();
                }

            }
        }
        public static void SnakeNewPosition() // новое место для появлении змейки
        {
            Game.snake.body.Clear();
            Game.snake.body.Add(new Point(new Random().Next(3, 69), new Random().Next(4, 19)));

        }
        public static bool SnakeinSnake()//проверка на появлении еды в змейке
        {
            for( int i=1; i<Game.snake.body.Count; i++)
            {
                if (Game.snake.body[0].x == Game.snake.body[i].x && Game.snake.body[0].y == Game.snake.body[i].y)
                    return true;               
            }
            return false;
        }
        public bool CollisionWithWall()// проверка на столкновение со стеной
        {
            for (int i=0; i<Game.wall.body.Count; i++)
            {
                if (body[0].x == Game.wall.body[i].x &&
                    body[0].y == Game.wall.body[i].y)
                    return true;
            }
            return false;
        }
            



            
    }
}
