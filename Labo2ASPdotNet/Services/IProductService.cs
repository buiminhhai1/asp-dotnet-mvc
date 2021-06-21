using System;
using System.Collections.Generic;
using Labo2ASPdotNet.Models.Entities;

namespace Labo2ASPdotNet.Services
{
    public interface IProductService
    {
        public List<Product> GetAll();

    }
}
