using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ecommerce_db
{
    internal class Payment
    {
       
        public int PaymentId { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public bool Status { get; set; }

        //Order
        public string OrderId { get; set; }
        public Order Order { get; set; }


        public Payment(int id, DateTime date, double amount)
        {
            PaymentId = id;
            Date = date;
            Amount = amount;
        }
    }

}
