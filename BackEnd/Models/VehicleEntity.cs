using BackEnd.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Models
{
    public class VehicleEntity : BaseProductEntity
    {
        public double Price { get; set; }
        public int ProductionYear { get; set; }
        public Conditions Condition { get; set; }
        public CarTypes Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
    }
}
