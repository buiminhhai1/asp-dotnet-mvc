using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Labo2ASPdotNet.Controllers
{
    [Area("Main")]
    public class SampleController : Controller
    {
        // GET: /Sample/Blank/
        public IActionResult Blank()
        {
            return View();
        }

        // GET: /Sample/Login
        public IActionResult Login()
        {
            return View();
        }
    }
}
