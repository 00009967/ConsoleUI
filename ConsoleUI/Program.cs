using Repositories;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueSearch = true;
            while (continueSearch)
            {
                Console.WriteLine("Welcome to our Online Store");
                Console.WriteLine("In order to proceed press Enter");
                Console.ReadKey();
                Console.WriteLine("Here is he list of Cars");
                Console.WriteLine("==============================<><><><<><>=====================================");

                var vehicles = Factory.VehicleRepository().GetAllVehicles();

                foreach (var vehicle in vehicles)
                {
                    Console.WriteLine($"Brand:                  {vehicle.Brand}");
                    Console.WriteLine($"Price:                  {vehicle.Price}");
                    Console.WriteLine($"Production Year:        {vehicle.ProductionYear}");
                    Console.WriteLine("==============================<><><><<><>=====================================");
                }

                Console.WriteLine("Do you want to continue press - C and Enter \nDo you want to stop it press - Q and Enter");
                string userResponse = Console.ReadLine();
                if (userResponse.Contains("q")) continueSearch = false;
                if (userResponse.Contains("c")) continueSearch = true;
            }
        }
    }
}
