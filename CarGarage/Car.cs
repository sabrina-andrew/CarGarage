using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car
    {
        public int Speed { get; private set; }
        public int GasLevel { get; private set; }
        public bool CarStarted { get; private set; }
        public string CarName { get; private set; }
        public string Color { get; private set; }



        public Car()
        {
            //Set Stats
            Speed = 0;
            GasLevel = 100;
            CarStarted = false;

            switch (VehicleInformation)
            {
                case "1":
                    Console.WriteLine("What is the Make and Model of your vehicle?");
                    CarName = Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("What is the color of your vehicle?");
                    Color = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Please follow the instructions.");
                    break;
            }
        }

        public void DisplayAllVehicleInfo()
        {
            Console.WriteLine("\nMake and Model: " + CarName);
            Console.WriteLine("Color: " + Color);
        }
           
            public Car(int startGasLevel)
        {
            Speed = 0;
            GasLevel = startGasLevel;
            CarStarted = false;
        }

        public void Accelerate()
        {
            Speed += 10;
            GasLevel -= 10;
        }

        public void TestDrive()
        {
            CarStarted = true;
            Accelerate();

        }

        public void AddFuel()
        {
            GasLevel = 100;
        }

        public void Brake()
        {
            Speed -= 10;

            if (Speed < 0)
            {
                Speed = 0;
            }
        }

        public void ToggleEngine()
        {
            CarStarted = !CarStarted;
        }
    }
}
