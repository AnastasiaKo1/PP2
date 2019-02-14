using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        public static void Probels(int x)// функция для пробелов int - отступ
        {
            for (int i = 0; i < x; i++)
            {
                Console.Write("     ");
            }
        }
        public static void Folders(DirectoryInfo dir, int x)// фукция чтобы получить названия папки или файла
        {
            foreach (FileInfo files in dir.GetFiles())//берет названия всех файлов и выводит
            {
                Probels(x);// вызывваем функцию пробелов
                Console.WriteLine(files.Name);
            }
            foreach (DirectoryInfo direct in dir.GetDirectories())// папки 
            {
                Probels(x);
                Console.WriteLine(direct.Name);
                Folders(direct, x + 1);// рекурсия, в каждую папку входит
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\asus\Desktop\GitHub\pp2");// указываем папку с которой работаем

            Folders(d, 0);// вызываем функцию
        }
    }
}
