using System;
using Microsoft.AspNetCore.Mvc;

namespace Labo2ASPdotNet.Areas.Main.Controllers
{
    [Area("Main")]
    public class RegisterController : Controller
    {
        public RegisterController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
