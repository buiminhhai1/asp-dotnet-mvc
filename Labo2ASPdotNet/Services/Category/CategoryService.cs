using System;
using System.Collections.Generic;
using System.Linq;
using Labo2ASPdotNet.Database;
using Labo2ASPdotNet.Models;
using Labo2ASPdotNet.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Labo2ASPdotNet.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext dataContext = null;

        public CategoryService(DataContext context)
        {
            dataContext = context;
        }


        public void CreateOne(CreateCategoryModel model)
        {
            var exitCategory = dataContext.Categories.FirstOrDefault(c => c.Name == model.Name);

            if (exitCategory != null)
            {
                throw new DuplicateWaitObjectException(model.Name + " Already existing!");
            }

            var category = new Category
            {
                Name = model.Name
            };

            dataContext.Categories.Add(category);
            dataContext.SaveChanges();
            
        }

        public void DeleteById(int id)
        {
            var category = dataContext.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                throw new DllNotFoundException();
            }
            dataContext.Categories.Remove(category);
            dataContext.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return dataContext.Categories.ToList();
        }

        public Category GetById(int id)
        {
            var category = dataContext.Categories.FirstOrDefault(c => c.Id == id);
            return category;
        }

        public void UpdateById(int id, CreateCategoryModel model)
        {
            var category = dataContext.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                throw new DllNotFoundException();
            }
            category.Name = model.Name;
            dataContext.Entry(category).State = EntityState.Modified;
            dataContext.SaveChanges();
        }
    }
}
