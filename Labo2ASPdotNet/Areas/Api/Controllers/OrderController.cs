using System;
using System.Threading.Tasks;
using Labo2ASPdotNet.Models;
using Labo2ASPdotNet.Models.Entities;
using Labo2ASPdotNet.Services;
using Labo2ASPdotNet.Wrappers.Filters;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Labo2ASPdotNet.Areas.Api.Controllers
{
    [Area("Api")]
    [Route("Api/Orders")]
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }


        [HttpGet]
        public JsonResult GetAll([FromQuery] PaginationFilter filter)
        {
            var route = Request.Path.Value;
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var data = orderService.GetAll(validFilter, route);
            return Json(data);
        }

        [HttpPost]
        public void CreateOne([FromBody] Object model)
        {
            var user = (User)HttpContext.Items["User"];
            var jsonString = model.ToString();
            CreateOrderModel orderModel = JsonConvert
                .DeserializeObject<CreateOrderModel>(jsonString);
            orderModel.UserId = user.Id;
            orderService.CreateOne(orderModel);
        }

        [HttpGet("{id}")]
        public JsonResult GetOrderById([FromRoute(Name = "id")] int id)
        {
            var data = orderService.GetOrderById(id);
            return Json(data);
        }

        [HttpPatch("{id}/status/{status}")]
        public void UpdateStatusForOrder([FromRoute(Name = "id")] int id,
            [FromRoute(Name ="status")] string status)
        {
            orderService.UpdateStatus(id, status);
        }

        [HttpDelete]
        public void DeleteById([FromRoute(Name = "id")] int id)
        {
            orderService.DeleteById(id);
        }

        [Route("users/{userId}")]
        [HttpGet]
        public JsonResult GetOrdersByUserId([FromRoute(Name = "userId")] int userId,
            [FromQuery] PaginationFilter filter)
        {
            
            var route = Request.Path.Value;
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var data = orderService.GetOrdersByUserId(userId, validFilter, route);
            return Json(data);
        }
    }
}
