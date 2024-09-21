using System;
using System.Threading;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 5;

            char symbol = '@';

            int width = Console.WindowWidth;
            int height = Console.WindowHeight;

            Console.CursorVisible = false;

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                    Console.SetCursorPosition(x, y);
                    Console.Write(' ');

                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            if (x > 0) x--;
                            break;
                        case ConsoleKey.RightArrow:
                            if (x < width - 1) x++;
                            break;
                        case ConsoleKey.UpArrow:
                            if (y > 0) y--;
                            break;
                        case ConsoleKey.DownArrow:
                            if (y < height - 1) y++;
                            break;
                    }

                    Console.SetCursorPosition(x, y);
                    Console.Write(symbol);
                }

                Thread.Sleep(5);
            }
        }
    }
}