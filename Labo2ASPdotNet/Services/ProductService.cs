using System;
using System.Collections.Generic;
using System.Linq;
using Labo2ASPdotNet.Database;
using Labo2ASPdotNet.Models.Entities;

namespace Labo2ASPdotNet.Services
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context = null;
        public ProductService(DataContext context)
        {
            _context = context;
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }
    }
}
