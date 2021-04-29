using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Labo2ASPdotNet.Controllers
{
    [Area("Main")]
    public class DetailController : Controller
    {
        // GET: /Detail/
        public IActionResult Index()
        {
            return View();
        }
    }
}
