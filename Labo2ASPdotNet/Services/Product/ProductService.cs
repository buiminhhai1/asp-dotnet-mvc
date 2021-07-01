using System;
using System.Collections.Generic;
using System.Linq;
using Labo2ASPdotNet.Database;
using Labo2ASPdotNet.Models;
using Labo2ASPdotNet.Models.Entities;
using Labo2ASPdotNet.Wrappers;
using Labo2ASPdotNet.Wrappers.Filters;
using Labo2ASPdotNet.Wrappers.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Labo2ASPdotNet.Services
{
    public class ProductService : IProductService
    {
        private readonly DataContext dataContext = null;
        private readonly IUriService uriService;
        public ProductService(DataContext context, IUriService uriService)
        {
            dataContext = context;
            this.uriService = uriService;
        }

        public void CreateOne(CreateProductModel productModel)
        {
            var product = new Product
            {
                Name = productModel.Name,
                Description = productModel.Description,
                Quantity = productModel.Quantity,
                Price = productModel.Price,
                Url = productModel.Url,
                CategoryId = productModel.CategoryId
            };
            dataContext.Products.Add(product);
            dataContext.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var product = dataContext.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                throw new DllNotFoundException();
            }
            dataContext.Products.Remove(product);
            dataContext.SaveChanges();
        }

        public PagedResponse<List<Product>> GetAll(PaginationFilter filter, string route)
        {
            var products = dataContext.Products
                    .Include(p => p.Category)
                    .Skip((filter.PageNumber - 1) * filter.PageSize)
                    .Take(filter.PageSize)
                    .OrderBy(p => p.Id)
                    .ToList();
            var totalCount = dataContext.Products.Count();
            
            var pageResponse = PaginationHelpers.CreatePagedReponse<Product>(products, filter, totalCount, uriService, route);
            return pageResponse;
        }

        public PagedResponse<List<Product>> GetByCategory(PaginationFilter filter, int categoryId, string route)
        {
            var productsByCategory = dataContext.Products.Where(p => p.CategoryId == categoryId)
                .Skip((filter.PageNumber - 1) * filter.PageSize)
                .Take(filter.PageSize)
                .OrderBy(p => p.Id)
                .ToList();
            var totalCount = dataContext.Products.Where(p => p.CategoryId == categoryId).Count();
            var pageResponse = PaginationHelpers.CreatePagedReponse<Product>(productsByCategory, filter, totalCount, uriService, route);
            return pageResponse;
        }

        public Product GetById(int id)
        {
            var product = dataContext.Products.Include(p => p.Category).FirstOrDefault(p => p.Id == id);
            return product;
        }

        public void UpdateById(int id, CreateProductModel productModel)
        {
            var product = this.GetById(id);
            if (product == null)
            {
                throw new DllNotFoundException();
            }

            product.Name = productModel.Name;
            product.Price = productModel.Price;
            product.Quantity = productModel.Quantity;
            product.Description = productModel.Description;
            product.Url = productModel.Url;

            dataContext.Entry(product).State = EntityState.Modified;
            dataContext.SaveChanges();
        }

        public List<Product> GetNewProduct()
        {
            var products = dataContext.Products.OrderByDescending(p => p.Id).Take(10).ToList();
            return products;
        }

        public List<Product> SearchByProductName(string productName)
        {
            var products = dataContext.Products
                    .Where(p => p.Name.ToLower().Contains(productName.ToLower()))
                    .Include(p => p.Category)
                    .ToList();
            return products;
        }
    }
}
