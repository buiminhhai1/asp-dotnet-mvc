using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Labo2ASPdotNet.Models
{
    public class OrderItemModel
    {
        public int ProductId { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }
    }

    public class CreateOrderModel
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public IEnumerable<OrderItemModel> OrderItemList;
    }
}
