using System;
using System.Collections.Generic;
using System.Text;
using Ecommerce.Entities.Enums;
using System.Globalization;

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
                sum += item.SubTotal();
            }

            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb  = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order Items: ");
            foreach(OrderItem item in OrderItems)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: R$ " + Total().ToString("f2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}