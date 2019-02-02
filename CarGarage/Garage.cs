using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class ParkingGarage
    {
        public List<Car> ListOfCars { get; set; }

        public ParkingGarage()
        {
            ListOfCars = new List<Car>();
        }

        public void AddCar()
        {
            ListOfCars.Add(new Car());
            Console.WriteLine("\n" + Car.CarName + " is parked in the garage.");
            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }

        public void RemoveCar(int whichCar)
        {
            ListOfCars.Remove(ListOfCars[whichCar]);
        }

        public void FuelAllCars()
        {
            foreach(Car thisCar in ListOfCars)
            {
                thisCar.AddFuel();
            }
        }
    }
}
