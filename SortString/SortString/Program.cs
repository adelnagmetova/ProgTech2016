using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Microsoft .NET Framework 2.0 Application Deevelopment Foundation";
            string[] sa = s.Split(' ');
            Array.Sort(sa);
            s = string.Join(" ", sa);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
