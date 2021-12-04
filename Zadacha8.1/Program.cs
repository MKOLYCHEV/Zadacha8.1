using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadacha8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Windows";
            if (Directory.Exists(path))
            {
                Console.WriteLine("Подкаталоги:");
                string[] directory = Directory.GetDirectories(path);
                foreach (string s in directory)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(path);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
    }
}
