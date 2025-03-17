using System;
using System.Collections.Generic;
using System.Linq;
using ManagerSystem.Interfaces;
using ManagerSystem.Models;

namespace ManagerSystem.Manager
{
    public class ProductManager : IGenericManager<Product>
    {
        private readonly SystemContext _context;

        public ProductManager(SystemContext context)
        {
            _context = context;
        }

        public void Add(params Product[] entities)
        {
            foreach (var product in entities)
            {
                _context.Products.Add(product);
            }
            _context.SaveChanges();
        }

        public void Update(params Product[] entities)
        {
            foreach (var product in entities)
            {
                var productToUpdate = _context.Products.SingleOrDefault(p => p.ProductId == product.ProductId);
                if (productToUpdate != null)
                {
                    productToUpdate.ProductName = product.ProductName;
                    productToUpdate.ProductPrice = product.ProductPrice;
                    productToUpdate.CategoryId = product.CategoryId;
                }
            }
            _context.SaveChanges();
        }

        public void Delete(params Product[] entities)
        {
            foreach (var product in entities)
            {
                var productToDelete = _context.Products.SingleOrDefault(p => p.ProductId == product.ProductId);
                if (productToDelete != null)
                {
                    _context.Products.Remove(productToDelete);
                }
            }
            _context.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products.SingleOrDefault(p => p.ProductId == id);
        }

        public string Display(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
