using ManagerSystem;
using ManagerSystem.Manager;
using ManagerSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<SystemContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

        var app = builder.Build();

        using (var scope = app.Services.CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<SystemContext>();
            
            var categoryManager = new CategoryManager(context);

            Category[] categories = new Category[]
            {
                new Category {CategoryName = "Elektronik"},
                new Category {CategoryName = "Giyim"},
                new Category {CategoryName = "Kozmetik"},
                new Category {CategoryName = "Spor"}
            };

            categoryManager.Add(categories);

            var productManager = new ProductManager(context);
            Product[] products = new Product[]
            {
                new Product {ProductName = "Iphone 12", ProductPrice = 10000, CategoryId = 1},
                new Product {ProductName = "Samsung S21", ProductPrice = 9000, CategoryId = 1},
                new Product {ProductName = "T-Shirt", ProductPrice = 50, CategoryId = 2},
                new Product {ProductName = "Jean", ProductPrice = 100, CategoryId = 2},
                new Product {ProductName = "Ruj", ProductPrice = 50, CategoryId = 3},
                new Product {ProductName = "Parfüm", ProductPrice = 200, CategoryId = 3},
                new Product {ProductName = "Spor Ayakkabı", ProductPrice = 300, CategoryId = 4},
                new Product {ProductName = "Spor T-Shirt", ProductPrice = 100, CategoryId = 4}
            };

            productManager.Add(products);
        }


        app.Run();
    }
}