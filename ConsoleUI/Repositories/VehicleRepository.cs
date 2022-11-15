using Data;
using Models;
using System;
using System.Collections.Generic;

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
            return _vehicleData.GetVehicles().FindAll(v => v.Model.Contains(model));
        }

        public List<VehicleEntity> GetSortedVehiclesByIndstry(string industry)
        {
            return _vehicleData.GetVehicles().FindAll(v => v.Type.Equals(industry));
        }
    }

}
