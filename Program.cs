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

        // Add services to the container.
        builder.Services.AddDbContext<SystemContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

        var app = builder.Build();

        // Veritabanını oluştur ve başlangıç verilerini ekle
        using (var scope = app.Services.CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<SystemContext>();
            
            // CategoryManager'e context ver
            var categoryManager = new CategoryManager(context);

            Category[] categories = new Category[]
            {
                new Category {CategoryName = "Elektronik"},
                new Category {CategoryName = "Giyim"},
                new Category {CategoryName = "Kozmetik"},
                new Category {CategoryName = "Spor"}
            };

            categoryManager.Add(categories);
        }


        app.Run();
    }
}