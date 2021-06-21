using System;
using System.Collections.Generic;
using Labo2ASPdotNet.Database;
using Labo2ASPdotNet.Models.Entities;

namespace Labo2ASPdotNet.Services
{
    public class OrderItemService : IOrderItemService
    {
        private readonly DataContext dataContext = null;

        public OrderItemService(DataContext context)
        {
            dataContext = context;
        }

        public OrderItem CreateOne(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteOne(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderItem> GetListByOrderId(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateOne(int id)
        {
            throw new NotImplementedException();
        }
    }
}
