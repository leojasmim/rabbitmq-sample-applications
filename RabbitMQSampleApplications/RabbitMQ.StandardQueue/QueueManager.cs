using RabbitMQ.Client;
using RabbitMQ.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQ.StandardQueue {
    public class QueueManager {

        private const string QueueName = "StandardQueueExample";

        private static ConnectionFactory _factory;
        private static IConnection _connection;
        private static IModel _channel;
        
        public void CreateQueue() {
            _factory = new ConnectionFactory() { HostName = "localhost", UserName = "guest", Password = "guest" };
            _connection = _factory.CreateConnection();
            _channel = _connection.CreateModel();
            _channel.QueueDeclare(QueueName, true, false, false, null);
        }

        public void SendMessage(Payment payment) {
            _channel.BasicPublish("", QueueName, null, payment.Serialize());
            PaymentManager.ShowPayment(payment, "Publisher");
        }
    }
}
