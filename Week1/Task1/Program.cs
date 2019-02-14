using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // ввожу число n и перевожу его в int и читаю его
            string s = Console.ReadLine();// ввожу строку 
            string[] ss = s.Split();//разделяю его элементы и ввожу массив
            int cnt = 0;//завела счетчик для счета простых чисел
            for (int i = 0; i < ss.Count(); i++)// пробегаюсь по элементам массива
            {
                int cnt2 = 0;//завела счетчик для подсчета сколько делителей
                int x = int.Parse(ss[i]);//ввела переменную х и перевела его в int во внутрь массива
                for (int j = 1; j <= x; j++)
                {
                    if (x % j == 0)//
                    {
                        cnt2++;
                    }
                }
                if (cnt2 == 2)
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
            for (int i = 0; i < ss.Count(); i++)
            {
                int cnt2 = 0;
                int x = int.Parse(ss[i]);
                for (int j = 1; j <= x; j++)
                {
                    if (x % j == 0)
                    {
                        cnt2++;
                    }
                }
                if (cnt2 == 2)
                {
                    Console.Write(x + " ");
                }
            }
        }
    }
}
