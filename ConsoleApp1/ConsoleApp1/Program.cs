using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        public static void Probels(int x)
        {
            for(int i=0; i<x; i++)
            {
                Console.Write("     ");
            }
        }
        public static void Folders(DirectoryInfo dir, int x)
        {
            foreach (FileInfo files in dir.GetFiles())
            {
                Probels(x);
                Console.WriteLine(files.Name);
            }
            foreach (DirectoryInfo direct in dir.GetDirectories())
            {
                Probels(x);
                Console.WriteLine(direct.Name);
                Folders(direct, x + 1);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\asus\Desktop\pp2\Новая папка");
            Folders(d, 0);
        }
    }
}
