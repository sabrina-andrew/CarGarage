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
            Console.WriteLine("\n" + CarName + " is parked in the garage.");
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

            public void DisplayAllVehicleInfo()
            {
                Console.WriteLine("\n\nPet Information:");

                int whichPet = PetSelectionMenu();
                switch (whichPet)
                {
                    case -2:
                        foreach (VirtualPet pet in PetsList)
                        {
                            Console.WriteLine("\n" + pet.Name + " Info: ");
                            pet.DisplayPetInfo();
                        }
                        break;
                    case -1:
                        Console.WriteLine("\n\nCancelled!");
                        break;
                    default:
                        PetsList[whichPet].DisplayPetInfo();
                        break;
                }
    }
}
