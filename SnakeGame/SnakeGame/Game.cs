using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Game
    {
        
        public static Food food = new Food();
        public static Snake snake = new Snake();
        public static Wall wall = new Wall();
        public bool GameOver = false;
        public Game ()
        {
           // Console.SetWindowPosition(30, 30);
            Init();
            Play();
        }
        public void Init()
        {            
            food.SetNewPosition();
            wall.Level(Wall.lvl);
        }
        


        public void Play()
        {
            while (!GameOver)
            {
                Draw();
                ConsoleKeyInfo button = Console.ReadKey();
               
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
                    GameOver = snake.CollisionWithWall();
                if (Food.FoodinSnake())
                    Game.food.SetNewPosition();
                GameOver = Snake.SnakeinSnake();

                }
            
            Console.Clear();
            Console.SetCursorPosition(10, 10);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Game Over!");
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
        public static void NewPositionSnake()
        {
            snake.body.Clear();
            snake.body.Add(new Point(new Random().Next(2, 70), new Random().Next(3, 18)));
            Game.Draw();
        }

    }
}
