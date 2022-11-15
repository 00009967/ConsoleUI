using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Models
{
    public abstract class BaseProductEntity
    {
        public int Id { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
