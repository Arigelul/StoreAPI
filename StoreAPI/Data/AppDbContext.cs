using Microsoft.EntityFrameworkCore;
using StoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { set; get; }
        public DbSet<Producer> Producers { set; get; }
        public DbSet<Customer> Customers { set; get; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Составной первичный ключ
            modelBuilder.Entity<Order>()
                 .HasKey(e => new { e.CustomerId, e.ProductId });
        }

        public DbSet<Order> Orders { get; set; }
    }
}
