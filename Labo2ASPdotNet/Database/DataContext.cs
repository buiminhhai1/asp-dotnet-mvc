using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Labo2ASPdotNet.Models;
using Labo2ASPdotNet.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Labo2ASPdotNet.Database
{
    public class DataContext : DbContext
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DataContext(DbContextOptions<DataContext> options, IHttpContextAccessor httpContext) : base(options)
        {
            httpContextAccessor = httpContext;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(a => new { a.Username, a.Email })
                .IsUnique(true);

            modelBuilder.Entity<User>()
                .Property(a => a.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Product>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Category>()
                .HasIndex(c => new { c.Name })
                .IsUnique(true);

            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(c => c.Category)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Category>()
                .Property(a => a.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderItems)
                .WithOne(i => i.Order)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderItem>()
                .HasOne(o => o.Order)
                .WithMany(i => i.OrderItems)
                .IsRequired(true);

            modelBuilder.Entity<Order>()
               .Property(a => a.Id)
               .ValueGeneratedOnAdd();

            modelBuilder.Entity<OrderItem>()
                .HasOne(o => o.Product)
                .WithMany(p => p.OrderItems)
                .IsRequired(true);

            modelBuilder.Entity<OrderItem>()
                .Property(a => a.Id)
                .ValueGeneratedOnAdd();


        }
    }
}
