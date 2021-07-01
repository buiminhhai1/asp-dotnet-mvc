using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Labo2ASPdotNet.Models;
using Labo2ASPdotNet.Models.Entities;
using Labo2ASPdotNet.Wrappers;
using Labo2ASPdotNet.Wrappers.Filters;

namespace Labo2ASPdotNet.Services
{
    public interface IOrderService
    {
        public PagedResponse<List<Order>> GetAll(PaginationFilter filter, string route);

        public void CreateOne(CreateOrderModel model);

        public void UpdateStatus(int id, string status);

        public void DeleteById(int id);

        public Order GetOrderById(int id);

        public PagedResponse<List<Order>> GetOrdersByUserId(int userId, PaginationFilter filter, string route);
    }
}
