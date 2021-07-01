using System;
using System.Collections.Generic;
using Labo2ASPdotNet.Models;
using Labo2ASPdotNet.Models.Entities;
using Labo2ASPdotNet.Wrappers;
using Labo2ASPdotNet.Wrappers.Filters;

namespace Labo2ASPdotNet.Services
{
    public interface IProductService
    {
        public PagedResponse<List<Product>> GetAll(PaginationFilter filter, string route);

        public List<Product> GetNewProduct();

        public void CreateOne(CreateProductModel productModel);

        public Product GetById(int id);

        public void UpdateById(int id, CreateProductModel productModel);

        public void DeleteById(int id);

        public PagedResponse<List<Product>> GetByCategory(PaginationFilter filter, int categoryId, string route);

        public List<Product> SearchByProductName(string productName);
    }
}
