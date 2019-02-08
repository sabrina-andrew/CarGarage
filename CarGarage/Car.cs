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
        int Year { get; set; }
        string Make { get; set; }
        string Model { get; set; }

        public Car(int year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
        }

        public Car()
        {
            //Set Stats
            Speed = 0;
            GasLevel = 100;
            CarStarted = false;
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
