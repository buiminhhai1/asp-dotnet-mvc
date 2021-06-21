using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Labo2ASPdotNet.Models;
using Labo2ASPdotNet.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Labo2ASPdotNet.Database
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(a => new { a.Username, a.Email })
                .IsUnique(true)
                ;

            modelBuilder.Entity<User>()
                .Property(a => a.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Product>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Category>()
                .Property(c => c.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Order>()
                .Property(o => o.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<OrderItem>()
                .Property(o => o.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
