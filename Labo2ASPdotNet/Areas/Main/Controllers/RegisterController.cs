using Labo2ASPdotNet.Models;
using Labo2ASPdotNet.Models.Entities;
using Labo2ASPdotNet.Services;
using Microsoft.AspNetCore.Mvc;

namespace Labo2ASPdotNet.Areas.Main.Controllers
{
    [Area("Main")]
    public class RegisterController : Controller
    {
        private readonly IUserService userService;
        public RegisterController(IUserService service)
        {
            userService = service;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(RegisterModel model)
        {
            model.Role = Role.User;
            var result = userService.CreateOne(model);
            if (ModelState.IsValid != true || result != true)
            {
                ModelState.AddModelError("", "Invalid Register Information");
                return View(model);
            }
            if (result == true)
            {
                return RedirectToAction("Welcome", "Home", new { Area = "Main" });
            }
            return View(model);
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
