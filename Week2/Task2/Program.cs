using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader(@"C:\Users\asus\Desktop\pp2\Новая папка\task2.txt");
            string[] s = r.ReadToEnd().Split();
            StreamWriter w = new StreamWriter(@"C:\Users\asus\Desktop\pp2\Новая папка\task2_2.txt");
            for (int i = 0; i < s.Length; i++)
            {
                int cnt = 0;
                int x = int.Parse(s[i]);
                for (int j = 1; j <= x; j++)
                {
                    if (x % j == 0)
                    {
                        cnt++;
                    }
                }
                if (cnt == 2)
                {
                    w.Write(s[i] + " ");
                }
            }
            w.Close();
        }
    }
}
