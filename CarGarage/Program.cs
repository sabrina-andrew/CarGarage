using System;

namespace CarGarage
{
    public class Program
    {
        static void Main(string[] args)
        {
            ParkingGarage parkingGarage = new ParkingGarage();

            MainMenu();
        }
        static void MainMenu()
        {
            Console.WriteLine("Welcome to the Garage.");
            Console.WriteLine("Press 1 to park your car");
            Console.WriteLine("Press 0 to exit");
            string parkedCar = Console.ReadLine();

            if (parkedCar == "1")
            Console.WriteLine("What is the year of your vehicle?");
            int userInputYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the make of your vehicle?");
            string userInputMake = Console.ReadLine();
            Console.WriteLine("What is the model of your vehicle?");
            string userInputModel = Console.ReadLine();
        }
    }
}
