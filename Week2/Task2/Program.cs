using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader(@"C:\Users\asus\Desktop\pp2\Новая папка\task2.txt");//читаю файловый текст и придаю значение
            string[] s = r.ReadToEnd().Split();//создаю массив в файле из содержимого, считываю весть текст из файла и разойденяю
            StreamWriter w = new StreamWriter(@"C:\Users\asus\Desktop\pp2\Новая папка\task2_2.txt");//через SW записываем в новый файл 
            for (int i = 0; i < s.Length; i++)//пробегаемся по массиву
            {
                int cnt = 0;//счетчик для счета делителей
                int x = int.Parse(s[i]);//переводим х в каждый элемент массива
                for (int j = 1; j <= x; j++)//все числа до х
                {
                    if (x % j == 0)
                    {
                        cnt++;
                    }
                }
                if (cnt == 2)//если кол-во делителей равно двум
                {
                    w.Write(s[i] + " ");//выводим простые числа в новый файл
                }
            }
            w.Close();//закрываем   
        }
    }
}