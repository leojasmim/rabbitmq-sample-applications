using RabbitMQ.Common;
using RandomNameGeneratorLibrary;
using System;
using System.Collections.Generic;

namespace RabbitMQ.StandardQueue {
    class Program {

       public static void Main(string[] args) {

            List<Payment> payments = PaymentManager.CreatePayments(numberOfPayments: 10);

            foreach (Payment pay in payments) {
                PaymentManager.ShowPayment(pay);
            }

        }

    }
}
