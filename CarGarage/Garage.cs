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

        public void AddCar(int year, string make, string model)
        {
            Car addedCar = new Car(year, make, model);
            ListOfCars.Add(addedCar);

            Console.WriteLine(year + make + model + "is parked.");
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();
        }

        public void RemoveCar(int whichCar)
        {
            ListOfCars.Remove(ListOfCars[whichCar]);
        }

        public void FuelAllCars()
        {
            foreach (Car thisCar in ListOfCars)
            {
                thisCar.AddFuel();
            }
        }
    }
}
