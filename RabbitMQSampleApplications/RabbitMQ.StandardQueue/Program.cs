using RabbitMQ.Client;
using RabbitMQ.Common;
using RandomNameGeneratorLibrary;
using System.Threading;
using System.Collections.Generic;

namespace RabbitMQ.StandardQueue {
    class Program {
               
        
        public static void Main(string[] args) {

            QueueManager queueManager = new QueueManager();
            List<Payment> payments = PaymentManager.CreatePayments(numberOfPayments: 100000);

            queueManager.CreateQueue();

            foreach (Payment payment in payments) {
                queueManager.SendMessage(payment);
            }

            Thread.Sleep(10000);

            queueManager.Reciever();
        }

    }
}
