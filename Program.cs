using CarSimulator.Domain;
using System;
using System.Threading;
using static System.Console;
namespace CarSimulator
{
    class Program
    {
       static Car[] carList = new Car[10];
        static void Main(string[] args)
        {
            bool exit = false;

           
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
                WriteLine("3. Change Number Plate");
                SetCursorPosition(2, 4);
                WriteLine("4. Simulate speed");
                SetCursorPosition(2, 5);
                WriteLine("5. Exit");

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


                        Write("Number Plate: ");
                        string numPlate = ReadLine();


                        Car newCar = new Car(brand, model, numPlate);
                        carList[carListIndex++] = newCar;
                        break;

                      
                    case ConsoleKey.D2:
                        WriteLine(" Brand         Model     Number Plate     ");
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
                        {

                            Write("Previous Number Plate: ");
                            string previousNumPlate = ReadLine();
                            Clear();
                            Write("New Number Plate: ");
                            string newNumPlate = ReadLine();
                            Clear();
                            Car theCar = SearchCarByRegistrationNumber(previousNumPlate);
                            Clear();
                            if (theCar != null)
                            {
                                theCar.SetNumPlate(newNumPlate);
                            }
                            else
                            {
                                WriteLine("Car not found");

                                Thread.Sleep(2000);
                            }
                        }


                        break;
                    case ConsoleKey.D5:

                        exit = true;

                        break;
                }
            }
            
        }
        private static Car SearchCarByRegistrationNumber(string previousRegistrationNumber)
        {
            Car carReferenceToReturn = null;

            foreach (Car carReference in carList)
            {
                if (carReference == null) continue;

                if (carReference.NumPlate == previousRegistrationNumber)
                {
                    carReferenceToReturn = carReference;
                    break;
                }
            }

            return carReferenceToReturn;
        }
    }

}
