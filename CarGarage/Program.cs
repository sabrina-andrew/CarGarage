using System;

namespace CarGarage
{
    public class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("You have entered the parking garage!\n");

                bool run = true;

                var TheGarage = new ParkingGarage();

                do
                {
                    run = MainMenu(TheGarage);
                } while (run);
            }

        static bool MainMenu(ParkingGarage Garage)
        {
            Console.Clear();

            Console.WriteLine("Press 1 to Put Your Car in the Garage.");

            if (Garage.ListOfCars.Count > 0)
            {

                Console.WriteLine("Press 2 to Display Vehicle Information.");
                Console.WriteLine("Press 3 to Display Vehicle Stats.");
                Console.WriteLine("Press 4 to Do Stuff To Your Car.");
                Console.WriteLine("Press 5 to Leave The Garage.");
            }
            Console.WriteLine("Press 0 to Exit");

            ConsoleKeyInfo keyPressed = Console.ReadKey();

            string menuChoice;

            if (char.IsDigit(keyPressed.KeyChar))
            {
                menuChoice = keyPressed.KeyChar.ToString();
            }
            else
            {
                menuChoice = "default";
            }
            switch (menuChoice)
            {
                case "0":
                    Console.WriteLine("\nSee you later alligator!");
                    return false;
                case "1":
                    Console.WriteLine("\n\nTell us about your car.");
                    Garage.AddCar();
                    break;
                case "2":
                    ParkingGarage.DisplayAllVehicleInfo();
                    break;
            }
           return true;
        }
    }
}
