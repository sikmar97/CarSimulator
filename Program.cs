using CarSimulator.Domain;
using System;
using static System.Console;
namespace CarSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            Car[] carList = new Car[10];
            uint carListIndex = 0;

            while (exit == false)
            {
                Clear();
                CursorVisible = false;
                SetCursorPosition(2, 1);
                WriteLine("1. Add car");
                SetCursorPosition(2, 2);
                WriteLine("2. List cars");
                SetCursorPosition(2, 3);
                WriteLine("3. Simulate speed");
                SetCursorPosition(2, 4);
                WriteLine("4. Exit");

                Console.CursorVisible = false;

                ConsoleKeyInfo input = ReadKey(true);

                Clear();

                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        CursorVisible = true;
                        Write("Brand: ");
                        string brand = ReadLine();
                        
                        Write("Model: ");
                        string model = ReadLine();


                        Write("NumberPlate: ");
                        string numPlate = ReadLine();


                        Car newCar = new Car(brand, model, numPlate);
                        carList[carListIndex++] = newCar;
                        break;

                      
                    case ConsoleKey.D2:
                        WriteLine(" Brand         Model     Numplate     ");
                        WriteLine("-----------------------------------------");




                        foreach (Car car in carList)
                        {


                            if (car == null)
                            {
                                continue;
                            }
                            else
                            {

                                Console.WriteLine(" "+ car.Brand + "           " + car.Model+"        " + car.NumPlate);
                            }
                             

                        }


                        
                        WriteLine("");
                        CursorVisible = true;
                        SetCursorPosition(1, 12);
                        Write("<Press Any Key To Continue>");
                        ReadKey();
                        break;

                    case ConsoleKey.D3:



                        break;
                    case ConsoleKey.D4:

                        exit = true;

                        break;
                }
            }

        }
    }
}
