using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows;
using System.Threading.Tasks;

namespace Complex1
{
    class fraction
    {
        public int x, y;
        public fraction()
        {
            x = y = 0;
        }
        public fraction(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return x + "/" + y;
        }
        static public fraction operator + (fraction a, fraction b)
        {
            int numerator = a.x * b.y + b.x * a.y, denominator = a.y * b.y;
            int g = gcd(numerator, denominator);
            //if (g == 0) return a;
            numerator /= g;
            denominator /= g;
            return new fraction(numerator, denominator);
        }

        private static int gcd(int a, int b)
        {
            if (b == 0) return a;
            return gcd(b, a % b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] token = Console.ReadLine().Split();
            int up = int.Parse(token[0]), down = int.Parse(token[1]);
            fraction a = new fraction(up, down);
            token = Console.ReadLine().Split();
            up = int.Parse(token[0]); down = int.Parse(token[1]);
            fraction b = new fraction(up, down);
            fraction c = a + b;
            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
}
