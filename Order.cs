using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ecommerce_db
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public bool Status { get; set; }

        // Customer
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        // Employee
        public int EmployeeId { get; set; }
        public Employee Employees { get; set; }

        // Payments
        public List<Payment> Payments { get; set; }

        //Orders
        public List<Product> Products { get; set; }

    }
}
