using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagerSystem.Interfaces;
using ManagerSystem.Models;

namespace ManagerSystem.Manager
{
    public class ProductManager : IGenericManager<Product>
    {
        public void Add(params Product[] entity)
        {
            throw new NotImplementedException();
        }
        public void Update(params Product[] entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(params Product[] entity)
        {
            throw new NotImplementedException();
        }

        public string Display(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}