using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerSystem.Interfaces
{
    public interface IGenericManager <T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(params T[] entity);
        void Update(params T[] entity);
        void Delete(params T[] entity);

        string Display(T entity);
    }
}