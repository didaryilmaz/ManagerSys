using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerSystem.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public double? ProductPrice { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}