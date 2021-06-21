using System;
using System.Collections.Generic;
using Labo2ASPdotNet.Models.Entities;

namespace Labo2ASPdotNet.Services
{
    public interface ICategoryService
    {
        public Category CreateOne();
        public void Update();
        public List<Category> GetAll();
    }
}
