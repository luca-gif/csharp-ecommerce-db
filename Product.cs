using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ecommerce_db
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        //Orders
        public List<Order> Orders { get; set; }

        public Product(int id, string name, string description, double price)
        {
            ProductId = id;
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
