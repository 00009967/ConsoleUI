using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.Services
{
    public class VehicleService : IVehicleService
    {
        IVehicleRepository _vehicleRepository;
        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public void HandleVehicleRequest()
        {
            List<VehicleEntity> vehicles = new List<VehicleEntity>();

            Console.WriteLine("Do you want to see all vehicles? - Press 1 and Enter");
            Console.WriteLine("Do you want to sort by Model? - Press 2 and Enter");
            Console.WriteLine("Do you want to sort by Industry? - Press 3 and Enter");
            var input = Console.ReadLine();
            int convertedInput = Int32.Parse(input);


            switch (convertedInput)
            {
                case 1:
                    vehicles = Case1();
                    break;
                case 2:
                    vehicles = Case2();
                    break;
                case 3:
                    vehicles = Case3();
                    break;
                default:
                    Console.WriteLine("Sorry I cannot process your input because it is beyond my capability!");
                    break;
            }

            Console.WriteLine("==============================<><><><<><>=====================================");

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Model:                  {vehicle.Model}");
                Console.WriteLine($"Price:                  {vehicle.Price}");
                Console.WriteLine($"Production Year:        {vehicle.ProductionYear}");
                Console.WriteLine($"Industry:               {vehicle.Type}");
                Console.WriteLine("==============================<><><><<><>=====================================");
            }
        }

        private List<VehicleEntity> Case1()
        {
            return _vehicleRepository.GetAllVehicles();
        }

        private List<VehicleEntity> Case2()
        {
            Console.WriteLine("What model Interests you?");
            var model = Console.ReadLine();
            return _vehicleRepository.GetSortedVehiclesByModel(model);
        }

        private List<VehicleEntity> Case3()
        {

            Console.WriteLine("What indtustry car do you want?");

            Console.WriteLine("Press 0 and Enter for Industry");
            Console.WriteLine("Press 1 and Enter for Passenger");

            var industry = Int32.Parse(Console.ReadLine());
            return _vehicleRepository.GetSortedVehiclesByIndstry(industry);
        }

    }
}
