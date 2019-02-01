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

        public Car()
        {
            Speed = 0;
            GasLevel = 100;
        }

        public Car(int startGasLevel)
        {
            Speed = 0;
            GasLevel = startGasLevel;
        }

        public void Accelerate()
        {
            Speed += 10;
            GasLevel -= 10;
        }

        public void AddFuel()
        {
            GasLevel = 100;
        }

        public void shouldSlowDown()
        {

        }

    }
}
