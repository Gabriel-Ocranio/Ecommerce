using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Produtc Produtc { get; set; }
        public OrderItem(){}
        public OrderItem(int quantity, double price, Produtc produtc)
        {
            Quantity = quantity;
            Price = price;
            Produtc = produtc;
        }
        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}