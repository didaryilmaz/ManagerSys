using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ManagerSystem.Models;

namespace ManagerSystem
{
    public class SystemContext : DbContext
    {
        public SystemContext(DbContextOptions<SystemContext> options) : base(options)
        {
        }
        public SystemContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=managerSystemDb;Username=postgres;Password=ddrylmz");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
        .HasMany(e => e.Product)
        .WithOne(e => e.Category)
        .HasForeignKey(e => e.CategoryId)
        .HasPrincipalKey(e => e.Id);
        }
        public DbSet<ManagerSystem.Models.Category> Categories { get; set; }
        public DbSet<ManagerSystem.Models.Product> Products { get; set; }
    }
}