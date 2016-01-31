using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEx3
{
    class Program
    {

        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"c:\Proga");

            int index = 0;
            FileInfo[] files = d.GetFiles();
            bool showFileData = false;
            while (true)
            {
                if (showFileData == false)
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        if (index == i)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.WriteLine(files[i].Name);
                    }
                }
                ConsoleKeyInfo button = Console.ReadKey();
                if (button.Key == ConsoleKey.UpArrow)
                {
                    if (index > 0)
                        index--;
                }
                if (button.Key == ConsoleKey.DownArrow)
                {
                    if (index < files.Length - 1)
                        index++;
                }
                if (button.Key == ConsoleKey.Enter)
                {
                    FileStream f = new FileStream(files[index].FullName, FileMode.OpenOrCreate, FileAccess.Read);
                    StreamReader sr = new StreamReader(f);
                    Console.Write(sr.ReadToEnd());
                    sr.Close();
                    f.Close();
                    showFileData = true;

                }
                if (button.Key == ConsoleKey.Escape)
                    showFileData = false;

                if (showFileData == false)
                    Console.Clear();
            }
            Console.ReadKey();
        }
    }
}
