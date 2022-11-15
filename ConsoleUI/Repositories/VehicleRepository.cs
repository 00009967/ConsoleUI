using Data;
using Enums;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly VehicleData _vehicleData;

        public VehicleRepository()
        {
            _vehicleData = VehicleData.GetInstance();
        }

        public List<VehicleEntity> GetAllVehicles()
        {
            return _vehicleData.GetVehicles();
        }

        public List<VehicleEntity> GetSortedVehiclesByModel(string model)
        {
            return _vehicleData.GetVehicles().FindAll(v => v.Model.Equals(model));
        }

        public List<VehicleEntity> GetSortedVehiclesByIndstry(int industry)
        {
            CarTypes type = 0;
            switch (industry)
            {
                case 0:
                    type = CarTypes.Industrial;
                    break;
                case 1:
                    type = CarTypes.Passenger;
                    break;
                default:
                    Console.WriteLine("Your input not recognized");
                    break;
            }
            return _vehicleData.GetVehicles().FindAll(element => element.Type.Equals(type));
        }
    }

}
