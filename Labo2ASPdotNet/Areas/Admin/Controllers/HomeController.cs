using Labo2ASPdotNet.Models;
using Labo2ASPdotNet.Models.Entities;
using Labo2ASPdotNet.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Labo2ASPdotNet.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IUserService userService;
        public HomeController(IUserService service)
        {
            userService = service;
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
            var result = userService.VerifyUser(model, true);
            if (ModelState.IsValid != true || result != true)
            {
                ModelState.AddModelError("", "Invalid Login Information");
                return View(model);
            }

            if (result == true)
            {
                return RedirectToAction("Index", "AccountList", new { Area = "Admin" });
            }

            return View(model);
        }

        [Route("/Admin/AccountList")]
        public IActionResult AccountList()
        {
            var data = userService.GetAll();
            return View(data);
        }

        [Route("/Admin/Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Admin/Register")]
        public IActionResult Register(RegisterModel model)
        {
            model.Role = Role.Admin;
            var result = userService.CreateOne(model);
            if (ModelState.IsValid != true || result != true)
            {
                ModelState.AddModelError("", "Invalid Register Information");
                return View(model);
            }
            if (result == true)
            {
                return RedirectToAction("Welcome", "Home", new { Area = "Admin" });
            }
            return View(model);
        }

        [Route("/Admin/Home/Welcome")]
        public IActionResult Welcome()
        {
            return View();
        }
    }
}
