using System;
using System.Collections.Generic;
using Labo2ASPdotNet.Models;
using Labo2ASPdotNet.Models.Entities;

namespace Labo2ASPdotNet.Services
{
    public interface ICategoryService
    {
        public void CreateOne(CreateCategoryModel model);

        public Category GetById(int id);

        public void UpdateById(int id, CreateCategoryModel model);

        public void DeleteById(int id);

        public List<Category> GetAll();
    }
}
