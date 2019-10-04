using System;
using static System.Console;
namespace CarSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (exit == false)
            {
                Clear();

                SetCursorPosition(2, 1);
                WriteLine("1. Add car");
                SetCursorPosition(2, 2);
                WriteLine("2. List cars");
                SetCursorPosition(2, 3);
                WriteLine("3. Simulate speed");
                SetCursorPosition(2, 3);
                WriteLine("3. Exit");

                Console.CursorVisible = false;

                ConsoleKeyInfo input = ReadKey(true);

                Clear();

                switch (input.Key)
                {
                    case ConsoleKey.D1:



                        break;

                    case ConsoleKey.D2:



                        break;

                    case ConsoleKey.D3:



                        break;
                    case ConsoleKey.D:

                        exit = true;

                        break;
                }
            }

        }
    }
}
