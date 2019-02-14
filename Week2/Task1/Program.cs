using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader f = new StreamReader(@"C:\Users\asus\Desktop\pp2\Новая папка\abba.txt");
            string s = f.ReadToEnd();
            bool check = true;
            for (int i = 0; i < s.Length / 2; i++)
                if (s[i] != s[s.Length - i - 1])
                    check = false;
            if (check)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
