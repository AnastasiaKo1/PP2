using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//задаю число и перевожу его инт
            string[] a = Console.ReadLine().Split();//задаю массив и читаю его и разделяю
            string[] b = new string[n * 2];//создаю новый массив в котором будет в два раза больше элементов
            for (int i = 0; i < n; i++)//пробегаюсь по каждому элементу
            {
                b[i * 2] = a[i];
                b[i * 2 + 1] = a[i];
            }
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write(b[i] + " ");//вывожу новый массив
            }
        }
    }
}
