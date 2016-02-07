using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complexlab
{
    class Complex 
    {
        public int a, b;
        public Complex (int a, int b)
        {
            this.a = a;
            this.b = b;

        }
        public override string ToString()
        {
            return a + "/" + b;
          
        }
        /*public static Complex operator +(Complex c1, Complex c2)
        {
            int numerator = c1.a * c2.b + c2.a * c1.b;
            int denominator = c1.b * c2.b;
            int g = gcd(numerator, denominator);
            numerator /= g;
            denominator /= g;
            return new Complex(numerator, denominator); 

        }*/
        public static Complex operator -(Complex c1, Complex c2)
        {
            int numerator = c1.a * c2.b - c2.a * c1.b;
            int denominator = c1.b * c2.b;
            int g = gcd(numerator, denominator);
            numerator /= g;
            denominator /= g;
            return new Complex(numerator, denominator);
        }
        public  static int gcd(int x, int y)
        {
            if (y == 0)
                return x;
            return gcd(y, x % y);
        }
        static void Main(string[] args)
        {
            string[] token = Console.ReadLine().Split();
            int up = int.Parse(token[0]);
            int down = int.Parse(token[1]);
            Complex c1 = new Complex(up, down);
            token = Console.ReadLine().Split();
            up = int.Parse(token[0]);
            down = int.Parse(token[1]);
            Complex c2 = new Complex(up, down);
            Complex c3 = c1 - c2;
            Console.WriteLine(c3);
            Console.ReadKey();

        }
    }
}
