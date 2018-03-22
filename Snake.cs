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
            int xPos = 35;
            int yPos = 20;

            Console.SetCursorPosition(xPos, yPos);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine((char)2);
        }
    }
}
