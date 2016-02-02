using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Ex2
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
            int max = int.Parse(token[0]);
            foreach (string i in token)
            {
                if (int.Parse(i) >= max)
                    max = int.Parse(i);

            }
            int min = int.Parse(token[0]);
            foreach(string a in token)
            {
                if (int.Parse(a) < min)
                    min = int.Parse(a);
            }
            sw.WriteLine(max);
            sw.WriteLine(min);
            sw.Close();
            sr.Close();
            finput.Close();
            foutput.Close();
            Console.ReadKey();
        }
    }
}
