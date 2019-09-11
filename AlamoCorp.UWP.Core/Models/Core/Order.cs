using AlamoCorp.UWP.Core.Models.Enum;
using System;
using System.Collections.Generic;

using System.Text;

namespace AlamoCorp.UWP.Core.Models.Core
{
    public class Order
    {
        public long OrderID { get; set; }
        public DateTime CreatedDate { get; set; }
        public Customer Customer { get; set; }
        public List<CartLineItems> LineItems { get; set; }
        public decimal TotalAmount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public DeliveryMethod DeliveryMethod { get; set; }
        public DeliveryStatus DeliveryStatus { get; set; }

    }
}
