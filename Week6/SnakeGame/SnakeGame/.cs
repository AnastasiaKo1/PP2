using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.SetWindowSize(40, 40);
           Console.SetBufferSize(40, 40);

            Console.CursorVisible = false;

            while(true)
            {
                Console.SetCursorPosition(20, 20);
                Console.Write("O");
                Console.SetCursorPosition(30, 20);
                Console.Write("@");
                Console.SetCursorPosition(20, 30);
                Console.Write("###");

                ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();

                switch( keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        break;
                    case ConsoleKey.DownArrow:
                        break;
                    case ConsoleKey.LeftArrow:
                        break;
                    case ConsoleKey.RightArrow:
                        break;
                }

               


            }
            
 
        }
    }
}
