using Models;
using System.Collections.Generic;

namespace Repositories
{
    public interface IVehicleRepository
    {
        List<VehicleEntity> GetAllVehicles();
        List<VehicleEntity> GetSortedVehiclesByIndstry(string industry);
        List<VehicleEntity> GetSortedVehiclesByModel(string model);
    }
}