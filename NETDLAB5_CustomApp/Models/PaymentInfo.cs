using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NETDLAB5_CustomApp.Models
{
    public class PaymentInfo
    {
        [Key]
        public int paymentID { get; set; }
        public string paymentProvider { get; set; }
        public int cardNum { get; set; }
    }
}
