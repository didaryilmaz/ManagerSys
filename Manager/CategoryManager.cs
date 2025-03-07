using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagerSystem.Interfaces;
using ManagerSystem.Models;

namespace ManagerSystem.Manager
{
    public class CategoryManager : IGenericManager<Category>
    {
        public void Add(params Category[] entity)
        {
            throw new NotImplementedException();
        }
        public void Update(params Category[] entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(params Category[] entity)
        {
            throw new NotImplementedException();
        }

        public string Display(Category entity)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}