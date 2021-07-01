
using Labo2ASPdotNet.Services;
using Microsoft.AspNetCore.Mvc;

namespace Labo2ASPdotNet.Controllers
{
    [Area("Main")]
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService service)
        {
            orderService = service;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
