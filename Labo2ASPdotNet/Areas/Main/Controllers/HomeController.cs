using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Labo2ASPdotNet.Models;
using Labo2ASPdotNet.Services;

namespace Labo2ASPdotNet.Controllers
{
    [Area("Main")]
    public class HomeController : Controller
    {
        private readonly IUserService userService;

        public HomeController(IUserService service)
        {
            userService = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(LoginModel model)
        {
            var result = userService.VerifyUser(model);
            if (ModelState.IsValid != true || result != true)
            {
                ModelState.AddModelError("", "Invalid Login Information");
                return View(model);
            }

            if (result == true)
            {
                return RedirectToAction("Index", "Dashboard", new { Area = "Main" });
            }

            return View(model);
            
        }

        public IActionResult Welcome()
        {
            return View();
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
