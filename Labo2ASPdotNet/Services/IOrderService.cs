using System;
using System.Collections.Generic;
using Labo2ASPdotNet.Models.Entities;

namespace Labo2ASPdotNet.Services
{
    public interface IOrderService
    {
        public List<Order> GetAll();

        public Order CreateOne();
        public Order UpdateOne();
        public void DeleteOne();
        public Order GetOrderById();
    }
}
