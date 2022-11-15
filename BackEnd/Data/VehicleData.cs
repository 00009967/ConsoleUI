using BackEnd.Enums;
using BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Data
{
    public class VehicleData
    {
        private readonly static VehicleData _instance = new VehicleData();
        public List<VehicleEntity> vehicles;

        private VehicleData()
        {
            vehicles.AddRange(new List<VehicleEntity> {
                new VehicleEntity { Id = 1, Condition = Conditions.New, Price = 15366.50, ProductCategory= ProductCategory.Vehicle, ProductionYear=2022, Type = CarTypes.Passenger, Brand = "Toyota", Model="Supra" },
                new VehicleEntity { Id = 1, Condition = Conditions.Used, Price = 15366.50, ProductCategory= ProductCategory.Vehicle, ProductionYear=2015, Type = CarTypes.Industrial, Brand = "Toyota", Model="Hiace" },
                new VehicleEntity { Id = 1, Condition = Conditions.New, Price = 30000, ProductCategory= ProductCategory.Vehicle, ProductionYear=2022, Type = CarTypes.Passenger, Brand = "Chevrolet", Model="Malibu" },
                new VehicleEntity { Id = 1, Condition = Conditions.New, Price = 15366.50, ProductCategory= ProductCategory.Vehicle, ProductionYear=2022, Type = CarTypes.Industrial, Brand = "Ravon", Model="Damas" },
                new VehicleEntity { Id = 1, Condition = Conditions.Used, Price = 15366.50, ProductCategory= ProductCategory.Vehicle, ProductionYear=2020, Type = CarTypes.Passenger, Brand = "Chevrolet", Model="Nexia" },
                new VehicleEntity { Id = 1, Condition = Conditions.Used, Price = 15366.50, ProductCategory= ProductCategory.Vehicle, ProductionYear=2021, Type = CarTypes.Passenger, Brand = "Toyota", Model="Camry" },
            });
        }

        public static VehicleData GetInstance()
        {
            return _instance;
        }
    }
}
