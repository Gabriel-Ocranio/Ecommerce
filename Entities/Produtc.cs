using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Entities
{
    public class Produtc
    {
        public string Name { get; set; }
        public double Price { get; set; }
        Produtc() { }
        Produtc(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}