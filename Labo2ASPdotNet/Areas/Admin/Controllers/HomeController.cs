using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Labo2ASPdotNet.Database;
using Labo2ASPdotNet.Models;
using Labo2ASPdotNet.Models.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Labo2ASPdotNet.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private DataContext _context = null;
        public HomeController(DataContext context)
        {
            _context = context;
        }

        // GET: /
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
                return RedirectToAction("AccountList", "Home", new { Area = "Admin" });
            }
            else
            {
                ModelState.AddModelError("", "Invalid Login Information");
            }
            return View(model);
        }

        public ActionResult AccountList()
        {
            var data = _context.Accounts.ToList();
            return View(data);
        }
    }
}
