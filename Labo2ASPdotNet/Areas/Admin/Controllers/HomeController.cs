using System.Threading.Tasks;
using Labo2ASPdotNet.Models;
using Labo2ASPdotNet.Models.Entities;
using Labo2ASPdotNet.Services;
using Microsoft.AspNetCore.Authorization;
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
                return RedirectToAction("Index", "Dashboard", new { Area = "Admin" });
            }

            return View(model);
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

        [Route("/Admin/About")]
        public IActionResult About()
        {
            return View();
        }


        [Route("/Admin/Dashboard")]
        public IActionResult Dashboard()
        {
            return View();
        }

        [Route("/Admin/AllProduct")]
        public IActionResult AllProduct()
        {
            return View();
        }
        [Route("/Admin/TopProduct")]
        public IActionResult TopProduct()
        {
            return View();
        }

        [Route("/Admin/Category")]
        public IActionResult Category()
        {
            return View();
        }

        [Route("/Admin/Order")]
        public IActionResult Order()
        {
            return View();
        }

        // API Areas
        [Route("/Admin/AccountList")]
        public JsonResult AccountList()
        {
            var data = userService.GetAll();
            return Json(data);
        }

        [Route("/Admin/AccountList/User/{id}")]
        [HttpPut]
        public void BlockUser(int id, bool value)
        {
            userService.ChangeActiveStatus(id, value);
        }
    }
}
