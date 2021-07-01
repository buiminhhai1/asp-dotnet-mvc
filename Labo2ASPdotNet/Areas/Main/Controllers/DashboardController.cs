using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Labo2ASPdotNet.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Labo2ASPdotNet.Areas.Main.Controllers
{
    [Area("Main")]
    public class DashboardController : Controller
    {
        private readonly IProductService productService;

        public DashboardController(IProductService service)
        {
            productService = service;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            //var products = productService.GetAll();
            //return View(products);
            return View();
        }
    }
}
