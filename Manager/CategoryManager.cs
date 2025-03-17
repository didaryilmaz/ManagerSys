using System;
using System.Collections.Generic;
using System.Linq;
using ManagerSystem.Interfaces;
using ManagerSystem.Models;

namespace ManagerSystem.Manager
{
    public class CategoryManager : IGenericManager<Category>
    {
        private readonly SystemContext _context;

        public CategoryManager(SystemContext context)
        {
            _context = context;
        }

        public void Add(params Category[] entity)
        {
            try
            {
                foreach (var category in entity)
                {
                    _context.Categories.Add(category);
                    Console.WriteLine($"Kategori eklendi: {category.CategoryName}");
                }
                _context.SaveChanges();
                Console.WriteLine("Veritabanına başarıyla kaydedildi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata oluştu: {ex.Message}");
            }
        }



        public void Update(params Category[] entities)
        {
            foreach (var category in entities)
            {
                var categoryToUpdate = _context.Categories.SingleOrDefault(c => c.Id == category.Id);
                if (categoryToUpdate != null)
                {
                    categoryToUpdate.CategoryName = category.CategoryName;
                }
            }
            _context.SaveChanges();  // ✅ Değişiklikleri kaydet
        }

        public void Delete(params Category[] entities)
        {
            foreach (var category in entities)
            {
                var categoryToDelete = _context.Categories.SingleOrDefault(c => c.Id == category.Id);
                if (categoryToDelete != null)
                {
                    _context.Categories.Remove(categoryToDelete);
                }
            }
            _context.SaveChanges();  // ✅ Değişiklikleri kaydet
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return _context.Categories.SingleOrDefault(c => c.Id == id);
        }

        public string Display(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
