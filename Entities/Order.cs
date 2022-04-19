using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Entities.Enums;

namespace Ecommerce.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }
        public Order(){}
        public Order (DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }
        public double Total()
        {
            double sum = 0;
            foreach(OrderItem item in OrderItems)
            {
                sum = item.SubTotal();
            }

            return sum;
        }
    }
}