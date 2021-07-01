using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Labo2ASPdotNet.Database;
using Labo2ASPdotNet.Models;
using Labo2ASPdotNet.Models.Entities;
using Labo2ASPdotNet.Wrappers;
using Labo2ASPdotNet.Wrappers.Filters;
using Labo2ASPdotNet.Wrappers.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Labo2ASPdotNet.Services
{
    public class OrderService : IOrderService
    {
        private readonly DataContext dataContext = null;
        private readonly IUriService uriService;
        private readonly IOrderItemService orderItemService;

        public OrderService(DataContext dataContext, IOrderItemService orderItemService, IUriService uriService)
        {
            this.dataContext = dataContext;
            this.orderItemService = orderItemService;
            this.uriService = uriService;
        }

        public void CreateOne(CreateOrderModel model)
        {
            var dbContextTransaction = dataContext.Database.BeginTransaction();
            try
            {
                var order = new Order
                {
                    Status = OrderStatus.Pending,
                    UserId = model.UserId
                };

                dataContext.Orders.Add(order);
                dataContext.SaveChanges();

                foreach (OrderItemModel item in model.OrderItemList)
                {
                    orderItemService.CreateOne(item, order.Id);
                }
                dbContextTransaction.Commit();

            } catch (Exception e)
            {
                dbContextTransaction.Rollback();
                throw new DbUpdateException(e.ToString());
            }
        }

        public void DeleteById(int id)
        {
            var order = dataContext.Orders.FirstOrDefaultAsync(o => o.Id == id);
            if (order == null)
            {
                throw new DllNotFoundException("Not found order with id: " + id.ToString());
            }

            dataContext.Remove(order);
            dataContext.SaveChanges();
        }

        public PagedResponse<List<Order>> GetAll(PaginationFilter filter, string route)
        {
            var orders = dataContext.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(it => it.Product)
                .Include(o => o.User)
                .Skip((filter.PageNumber - 1) * filter.PageSize)
                .Take(filter.PageSize)
                .OrderBy(o => o.Id)
                .ToList();

            var totalCount = dataContext.Orders.Count();

            var pageResponse = PaginationHelpers.CreatePagedReponse<Order>(orders, filter, totalCount, uriService, route);
            return pageResponse;
        }

        public Order GetOrderById(int id)
        {
            var order = dataContext.Orders.Include(o => o.OrderItems).ThenInclude(it => it.Product).FirstOrDefault(o => o.Id == id);
            
            return order;
        }

        public PagedResponse<List<Order>> GetOrdersByUserId(int userId, PaginationFilter filter, string route)
        {
            
            var totalCount = dataContext.Orders.Where(o => o.UserId == userId).Count();
            var orders = dataContext.Orders
                .Where(o => o.UserId == userId)
                .Include(o => o.OrderItems)
                .ThenInclude(it => it.Product)
                .Include(o => o.User)
                .Skip((filter.PageNumber - 1) * filter.PageSize)
                .Take(filter.PageSize)
                .OrderBy(o => o.Id)
                .ToList();

            var pageResponse = PaginationHelpers.CreatePagedReponse<Order>(orders, filter, totalCount, uriService, route);
            return pageResponse;
        }

        public void UpdateStatus(int id, string status)
        {
            var order = dataContext.Orders.FirstOrDefault(o => o.Id == id);

            order.Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), status);

            dataContext.Entry(order).State = EntityState.Modified;
            dataContext.SaveChanges();
        }
    }
}
