using System;
using System.Collections.Generic;
using Labo2ASPdotNet.Database;
using Labo2ASPdotNet.Models.Entities;

namespace Labo2ASPdotNet.Services
{
    public class OrderService : IOrderService
    {
        private readonly DataContext dataContext = null;

        public OrderService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public Order CreateOne()
        {
            throw new NotImplementedException();
        }

        public void DeleteOne()
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetOrderById()
        {
            throw new NotImplementedException();
        }

        public Order UpdateOne()
        {
            throw new NotImplementedException();
        }
    }
}
