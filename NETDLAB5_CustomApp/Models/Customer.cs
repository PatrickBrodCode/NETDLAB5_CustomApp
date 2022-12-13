using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETDLAB5_CustomApp.Models
{
    public class Customer
    {
        public int customerID { get; set; }
        public string customerName { get; set; }
        
        public string customerAddress { get; set; }
        public string customerEmail { get; set; }

        //public string paymentID { get; set; }

        //public PaymentInfo PaymentInfo { get; set; }
        
    }
}
