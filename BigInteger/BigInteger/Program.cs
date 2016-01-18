using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;

namespace example
{
    class BigInteger
    {
        public int n;
        public int[] a = new int[3000];
        public override string ToString()
        {
            string ret = "";
            for (int i = n - 1; i >= 0; --i)
                ret += Convert.ToChar(a[i] + 48);
            return ret;
        }
        public BigInteger()
        {
            n = 0;
        }
        public BigInteger(string s)
        {
            n = s.Length;
            for (int i = 0; i < n; ++i)
                a[i] = Convert.ToInt32(s[n - i - 1] - '0');
        }
        public static BigInteger operator + (BigInteger x, BigInteger y)
        {
            BigInteger c = new BigInteger();
            c.n = Math.Max(x.n, y.n);
            int add = 0;
            for(int i = 0; i < c.n; ++i)
            {
                c.a[i] = x.a[i] + y.a[i] + add;
                add = c.a[i] / 10;
                c.a[i] %= 10;
            }
            if (add > 0) c.a[c.n++] = add;
            return c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger a = new BigInteger(Console.ReadLine());
            BigInteger b = new BigInteger(Console.ReadLine());
            BigInteger c = a + b;
            Console.WriteLine(c);
            Console.ReadKey();
        }

    }
}
