using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using team1.Models;

namespace team1.Data
{
    public class team1Context : DbContext
    {
        public team1Context (DbContextOptions<team1Context> options)
            : base(options)
        {
        }

        public DbSet<Customers> Customers { get; set; }

        public DbSet<GroupProduct> GroupProducts { get; set; } 

        public DbSet<Order> Orders { get; set; } 

        public DbSet<OrderDetail> OrderDetails { get; set; } 

        public DbSet<Product> Products { get; set; } 

        public DbSet<Users> Users { get; set; }
    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>().ToTable("Customers");
            modelBuilder.Entity<GroupProduct>().ToTable("GroupProduct");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<OrderDetail>().ToTable("OrderDetail");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Users>().ToTable("Users");
            modelBuilder.Entity<OrderDetail>()
                .HasKey(c => new { c.ProductId, c.OrderId });
            
        }
    }
}
