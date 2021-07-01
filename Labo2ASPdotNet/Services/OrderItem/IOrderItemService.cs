using Labo2ASPdotNet.Models;
using Labo2ASPdotNet.Models.Entities;

namespace Labo2ASPdotNet.Services
{
    public interface IOrderItemService
    {
        
        public OrderItem CreateOne(OrderItemModel model, int orderId);

        public void DeleteOne(int id);

        public void UpdateOne(int id);
    }
}
