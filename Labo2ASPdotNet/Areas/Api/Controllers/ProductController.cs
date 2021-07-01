using System;
using Labo2ASPdotNet.Models;
using Labo2ASPdotNet.Services;
using Labo2ASPdotNet.Wrappers.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Labo2ASPdotNet.Areas.Api.Controllers
{
    [Area("Api")]
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [Route("/Api/Products")]
        [HttpGet]
        public JsonResult GetAll([FromQuery] PaginationFilter filter)
        {
            var route = Request.Path.Value;
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var data = productService.GetAll(validFilter, route);
            return Json(data);
        }

        [Route("/Api/Products")]
        [HttpPost]
        public void CreateOne([FromBody] CreateProductModel productModel)
        {
            productService.CreateOne(productModel);
        }

        [Route("/Api/Products/{id}")]
        [HttpGet]
        public JsonResult CreateOne(int id)
        {
            var data = productService.GetById(id);

            return Json(data);
        }

        [Route("/Api/Products/{id}")]
        [HttpPut]
        public void UpdateById(int id, [FromBody] CreateProductModel productModel)
        {
            productService.UpdateById(id, productModel);
        }

        [Route("/Api/Products/{id}")]
        [HttpDelete]
        public void DeleteById(int id)
        {
            productService.DeleteById(id);
        }

        [Route("/Api/Products/categories/{categoryId}")]
        [HttpGet]
        public JsonResult GetByCategory([FromRoute( Name ="categoryId")]int categoryId, [FromQuery] PaginationFilter filter)
        {
            var route = Request.Path.Value;
            var data = productService.GetByCategory(filter, categoryId, route);
            return Json(data);
        }

        [Route("/Api/Products/NewProducts")]
        [HttpGet]
        public JsonResult GetNewProducts()
        {
            var data = productService.GetNewProduct();
            return Json(data);
        }

        [Route("/Api/Products/Name")]
        [HttpGet]
        public JsonResult SearchProductByName([FromQuery(Name = "productName")] string productName)
        {
            var data = productService.SearchByProductName(productName);
            return Json(data);
        }
    }
}
