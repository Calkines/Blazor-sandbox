using System;
using System.Collections.Generic;
using System.Text;

namespace Bs.Blog.Entities
{
    public class Order
    {
        public int OrderId { get; set; }

        public string UserId { get; set; }

        public DateTime CreatedTime { get; set; }

        public Address DeliveryAddress { get; set; } = new Address();

        public LatLong DeliveryLocation { get; set; }

        public List<Product> Pizzas { get; set; } = new List<Product>();

        public decimal GetTotalPrice() => Blog.Sum(p => p.GetTotalPrice());

        public string GetFormattedTotalPrice() => GetTotalPrice().ToString("0.00");
    }
}
