using System;
using System.Collections.Generic;
using Labo2ASPdotNet.Models.Entities;

namespace Labo2ASPdotNet.Services
{
    public interface IOrderItemService
    {
        public List<OrderItem> GetListByOrderId(int id);
        public OrderItem CreateOne(int id);
        public void DeleteOne(int id);
        public void UpdateOne(int id);
    }
}
