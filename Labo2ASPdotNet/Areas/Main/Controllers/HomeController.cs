using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Labo2ASPdotNet.Models;
using Labo2ASPdotNet.Database;

namespace Labo2ASPdotNet.Controllers
{
    [Area("Main")]
    public class HomeController : Controller
    {
        private DataContext _context = null;

        public HomeController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(LoginModel model)
        {
            var result = _context.Accounts.FirstOrDefault(a => a.Username == model.Username);
            if (result == null)
            {
                ModelState.AddModelError("", "Invalid Login Information");
                return View(model);
            }

            if (result != null && ModelState.IsValid && result.Password == model.Password)
            {
                return RedirectToAction("Index", "Dashboard", new { Area = "Main" });
            }
            else
            {
                ModelState.AddModelError("", "Invalid Login Information");
            }
            return View(model);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
