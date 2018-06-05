using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQ.Common
{
    [Serializable]
    public class Payment
    {
        public decimal AmountToPay { get; set; }
        public string CardNumber { get; set; }
        public string HolderName { get; set; }
    }
}
