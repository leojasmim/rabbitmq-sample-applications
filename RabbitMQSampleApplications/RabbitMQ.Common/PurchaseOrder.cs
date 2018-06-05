using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQ.Common
{
    public class PurchaseOrder
    {
        public decimal AmountToPay { get; set; }
        public string PONumber { get; set; }
        public string CompanyName { get; set; }
        public int PaymentDaysTerms { get; set; }
    }
}
