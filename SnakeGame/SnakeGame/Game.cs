using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Game
    {
        // создаются экземпляры классов
        public static Food food = new Food(); 
        public static Snake snake = new Snake();
        public static Wall wall = new Wall();
        public static bool GameOver = false;
        public Game ()
        {
           
            Init();
            Play();
        }
        public void Init()
        {            
            food.SetNewPosition(); // еда появляется 
            wall.Level(Wall.lvl); // появляется лабиринт уровня
            while( Food.FoodinSnake() == true|| Food.FoodinWall() == true)
            {
                food.SetNewPosition();
            }

            while(Game.snake.CollisionWithWall())
            {
                Snake.SnakeNewPosition();
            }
        }
        


        public void Play()
        {
            while (!GameOver) // пока змейка не столкнулась со стенкой
            {
                Draw(); // рисуем змейку, еду и лабиринт
                ConsoleKeyInfo button = Console.ReadKey(); // считываем кнопки движения
               
                    if (button.Key == ConsoleKey.UpArrow)
                        snake.move(0, -1);
                    if (button.Key == ConsoleKey.DownArrow)
                        snake.move(0, 1);
                    if (button.Key == ConsoleKey.LeftArrow)
                        snake.move(-1, 0);
                    if (button.Key == ConsoleKey.RightArrow)
                        snake.move(1, 0);
                    if (button.Key == ConsoleKey.F2)
                        Save();
                    if (button.Key == ConsoleKey.F3)
                        Resume();
                    if (button.Key == ConsoleKey.F5)
                        wall.Level(2);
                    //GameOver = snake.CollisionWithWall();// если змейка столкнулась, игра заканчивается
              
                }

            
            }
        public static void  EndGame() 
        {
            Console.Clear();// очищаем консоль
            Console.SetCursorPosition(10, 10);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Game Over!");// выводим надпись
            Console.WriteLine("Try again!");
            Console.ReadKey();

        }
        public static void Draw()
        {
            Console.Clear();
            Display.display();
            snake.Draw();
            food.Draw();
            wall.Draw();
        }
        public void Save()
        {
            snake.Save();
            food.Save();
            wall.Save();
        }
        public void Resume()
        {
            snake.Resume();
            food.Resume();
            wall.Resume();
        }
    }
}
