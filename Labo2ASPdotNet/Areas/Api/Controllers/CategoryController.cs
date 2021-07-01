using Labo2ASPdotNet.Models;
using Labo2ASPdotNet.Services;
using Microsoft.AspNetCore.Mvc;

namespace Labo2ASPdotNet.Areas.Api.Controllers
{
    [Area("Api")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService service)
        {
            categoryService = service;
        }

        [Route("/Api/Categories")]
        public JsonResult GetAll()
        {
            var data = categoryService.GetAll();
            return Json(data);
        }

        [Route("/Api/Categories")]
        [HttpPost]
        public void CreateOne([FromBody]CreateCategoryModel categoryModel)
        {
            categoryService.CreateOne(categoryModel);
        }

        [Route("/Api/Categories/{id}")]
        [HttpGet]
        public JsonResult GetById(int id)
        {
            var data = categoryService.GetById(id);
            return Json(data);
        }

        [Route("/Api/Categories/{id}")]
        [HttpPut]
        public void UpdateById(int id, [FromBody]CreateCategoryModel categoryModel)
        {
            categoryService.UpdateById(id, categoryModel);
        }

        [Route("/Api/Categories/{id}")]
        [HttpDelete]
        public void DeleteById(int id)
        {
            categoryService.DeleteById(id);
        }
    }

}
