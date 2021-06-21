using System;
using System.Collections.Generic;
using System.Linq;
using Labo2ASPdotNet.Database;
using Labo2ASPdotNet.Models.Entities;

namespace Labo2ASPdotNet.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext dataContext = null;

        public CategoryService(DataContext context)
        {
            dataContext = context;
        }

        public Category CreateOne()
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return dataContext.Categories.ToList();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
