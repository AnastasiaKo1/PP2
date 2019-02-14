using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = @"C:\Users\asus\Desktop\pp2\Новая папка";// сохраняю путь в стринг s
            string t = Path.Combine(s, "Lab2");// создала новый путь 
            Directory.CreateDirectory(t); // создаю папку
            string ss = "Task4.txt";//имя файла
            string tt = Path.Combine(t, ss);//создаю путь файла

            FileStream fs = File.Create(tt);// создала файл внутри папки
            fs.Close();
            s = Path.Combine(s, ss);// совместила файл и папку

            File.Copy(tt, s);// скопировлся
            //File.Move(tt,s);

            File.Delete(@"C:\Users\asus\Desktop\pp2\Новая папка\Lab2\Task4.txt");// удаляю оригинал файла
        }
    }
}