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
        SystemContext context = new SystemContext();
        public void Add(params Product[] entity)
        {
                foreach (var product in entity)
                {
                    context.Products.Add(product);
                }
                context.SaveChanges();
           
        }
        public void Update(params Product[] entities)
        {
                foreach (var entity in entities)
                {
                    var productToUpdate = context.Products.SingleOrDefault(p => p.ProductId == entity.ProductId);
                    if (productToUpdate != null)
                    {
                        productToUpdate.ProductName = entity.ProductName;
                        productToUpdate.ProductPrice = entity.ProductPrice;
                        productToUpdate.CategoryId = entity.CategoryId;
                    }
                }
                context.SaveChanges();
        }


        public void Delete(params Product[] entities)
        {
                foreach (var entity in entities)
                {
                    var productToDelete = context.Products.SingleOrDefault(p => p.ProductId == entity.ProductId);
                    if (productToDelete != null)
                    {
                        context.Products.Remove(productToDelete);
                    }
                }
                context.SaveChanges();
        }

        public string Display(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
                return context.Products.ToList();
        }

        public Product GetById(int id)
        {
                return context.Products.SingleOrDefault(p => p.ProductId == id);
        }

    }
}