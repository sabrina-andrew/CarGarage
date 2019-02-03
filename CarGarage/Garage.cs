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
           // Console.WriteLine("\n" + CarName + " is parked in the garage.");
            Console.WriteLine("\nPress ANY KEY to continue");
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

        public void DisplayAllVehicleInfo()
        {
            Console.WriteLine("\n\nVehicle Information:");

            int whichCar = CarSelectionMenu();
            switch (whichCar)
            {
                case -2:
                    foreach (Car car in ListOfCars)
                    {
                        Console.WriteLine("\n" + car.CarName + " Info: ");
                        car.DisplayVehicleInfo();
                    }
                    break;
                case -1:
                    Console.WriteLine("\n\nCancelled!");
                    break;
                default:
                    ListOfCars[whichCar].DisplayVehicleInfo();
                    break;
            }
        }
    }
}
