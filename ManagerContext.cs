using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagerSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace ManagerSystem
{
    public class ManagerContext : DbContext
    {
        public ManagerContext(DbContextOptions<ManagerContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=managerSystemDb;Username=postgres;Password=ddrylmz");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}