using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Drawer
    {
        public ConsoleColor color;
        public char sign;
        public List<Point> body = new List<Point>();

        public Drawer() { }

        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                if (p.x > 0 && p.y > 0 && p.x < Console.WindowWidth - 2 && p.y < Console.WindowHeight - 2)
                {
                    Console.SetCursorPosition(p.x, p.y);
                    Console.Write(sign);
                }
            }
        }

        public void Save()
        {
            string fileName = "";
            if (sign == '*')
                fileName = "food.xml";
            if (sign == '#')
                fileName = "wall.xml";
            if (sign == 'o')
                fileName = "snake.xml";

            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(GetType());

            xs.Serialize(fs, this);
            fs.Close();
        }

        public void Resume()
        {
            string fileName = "";
            if (sign == '*')
                fileName = "food.xml";
            if (sign == '#')

                fileName = "wall.xml";
            if (sign == 'o')
                fileName = "snake.xml";
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(GetType());

            if (sign == '*')
                Game.food = xs.Deserialize(fs) as Food;
            if (sign == '#')
                Game.wall = xs.Deserialize(fs) as Wall;

            if (sign == 'o')
                Game.snake = xs.Deserialize(fs) as Snake;

            fs.Close();

        }
    }
}
