﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ecommerce_db
{
    internal class Customer
    { 
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public List<Order> Orders { get; set; }

        public Customer(int id, string name, string surname, string email)
        {
            CustomerId = id;
            Name = name;
            Surname = surname;
            Email = email;
        }
    }
}
