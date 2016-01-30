using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Ex3
{
    class Program
    {
       
        static void Main(string[] args)
        {
            FileStream finput = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream foutput = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(finput);
            StreamWriter sw = new StreamWriter(foutput);
            string s = sr.ReadLine();
            string[] token = s.Split();
            int min = 0;
            foreach (string b in token)
            {
                int a = int.Parse(b);
                bool p = false;
                for (int i = 2; i * i <= a; i++)
                {
                    if (a % i == 0)
                        p = true;
                }
                if (p == false)
                {
                    if (a <= min)
                        min = a;
                    sw.WriteLine(min);
                    finput.Close();
                    foutput.Close();
                    sw.Close();
                    sr.Close();
                    Console.ReadKey();

                }
            }

        }
    }
}
