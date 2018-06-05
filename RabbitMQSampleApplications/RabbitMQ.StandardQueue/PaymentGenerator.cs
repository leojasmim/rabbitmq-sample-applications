using RabbitMQ.Common;
using RandomNameGeneratorLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQ.StandardQueue
{
    public static class PaymentManager
    {
        public static readonly string BIN = "41112222";
        public static readonly int MIN_CARD_NUMBER = 10000000;
        public static readonly int MAX_CARD_NUMBER = 99999999;

        public static void ShowPayment(Payment payment, string origin) {
            Console.WriteLine($"{origin}: Payment => Name: {payment.HolderName},Card: {payment.CardNumber}, Amount: {payment.AmountToPay}");
        }

        public static List<Payment> CreatePayments(int numberOfPayments) {

            var personGenerator = new PersonNameGenerator();

            List<Payment> payments = new List<Payment>();
            Random random = new Random();

            for (int i = 0; i < numberOfPayments; i++) {

                decimal amount = random.Next(1, 100);
                string card = BIN + random.Next(MIN_CARD_NUMBER, MAX_CARD_NUMBER).ToString();
                var name = personGenerator.GenerateRandomFirstAndLastName();

                payments.Add(new Payment() { AmountToPay = amount, CardNumber = card, HolderName = name });
            }

            return payments;
        }
    }
}
