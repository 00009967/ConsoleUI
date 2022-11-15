using BackEnd.Data;
using BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Repositories
{
    public class VehicleRepository
    {
        private readonly VehicleData _vehicleData;

        public VehicleRepository()
        {
            _vehicleData = VehicleData.GetInstance();
        }

        public List<VehicleEntity> GetAllVehicles()
        {
            return _vehicleData.vehicles;
        }

        public List<VehicleEntity> GetSortedVehiclesByModel(string model)
        {
            return _vehicleData.vehicles.FindAll(v => v.Model.Contains(model));
        }

        public List<VehicleEntity> GetSortedVehiclesByIndstry(string industry)
        {
            return _vehicleData.vehicles.FindAll(v => v.Type.Equals(industry));
        }
    }

}
