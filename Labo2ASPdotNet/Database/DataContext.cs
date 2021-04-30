using System;
using Labo2ASPdotNet.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Labo2ASPdotNet.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Account> Accouts { get; set; }
    }
}
