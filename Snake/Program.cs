using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 32;
            Console.WindowWidth = 32;
            var body = new List<Pixel>();
            BuildWall();

        }
        static void BuildWall()
        {
            Console.Clear();
            int ScreenHeight = 32;
            int ScreenHeight2 = 32;
            int ScreenWidth = 32;
            int ScreenWidth2 = 32;
            for (int i = 0; i < ScreenHeight; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.WriteLine("X");

                Console.SetCursorPosition(i, ScreenHeight2 - 1);
                Console.WriteLine("X");
            }

            for (int i = 0; i < ScreenWidth; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine("X");

                Console.SetCursorPosition(ScreenWidth2 - 1, i);
                Console.WriteLine("X");
            }
        }
        enum Direction
        {
            Up,
            Down,
            Right,
            Left
        }
    }
}