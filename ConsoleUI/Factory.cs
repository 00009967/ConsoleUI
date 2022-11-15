using ConsoleUI.Services;
using Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public static class Factory
    {
        public static IVehicleRepository VehicleRepository()
        {
            return new VehicleRepository();
        }

        public static IVehicleService VehicleService()
        {
            return new VehicleService(VehicleRepository());
        }
    }
}
