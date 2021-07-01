using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Labo2ASPdotNet.Database;
using Labo2ASPdotNet.Models;
using Labo2ASPdotNet.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Labo2ASPdotNet.Services
{
    public class OrderItemService : IOrderItemService
    {
        private readonly DataContext dataContext = null;

        public OrderItemService(DataContext context)
        {
            dataContext = context;
        }

        public OrderItem CreateOne(OrderItemModel model, int orderId)
        {
            var item = new OrderItem
            {
                OrderId = orderId,
                ProductId = model.ProductId,
                PriceInvoice = model.Price,
                Quantity = model.Quantity
            };
            dataContext.OrderItems.Add(item);
            dataContext.SaveChanges();

            return item;
        }

        public void DeleteOne(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateOne(int id)
        {
            throw new NotImplementedException();
        }
    }
}
