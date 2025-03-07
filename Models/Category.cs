using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerSystem.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public Product Product { get; set; }
        
    }
}