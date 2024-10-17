using Task_1.Model;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Task_1.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .HasColumnType("decimal(18, 2)");  // Set precision and scale for Price

        base.OnModelCreating(modelBuilder);
    }
    }
}
