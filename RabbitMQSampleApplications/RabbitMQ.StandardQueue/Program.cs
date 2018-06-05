using RabbitMQ.Common;
using RandomNameGeneratorLibrary;
using System;
using System.Collections.Generic;

namespace RabbitMQ.StandardQueue {
    class Program {

        public static readonly string BIN = "41112222";
        public static readonly int MIN_CARD_NUMBER = 10000000;
        public static readonly int MAX_CARD_NUMBER = 99999999;

        public static void Main(string[] args) {
            List<Payment> payments = CreatePayments(numberOfPayments: 10);

            foreach (Payment pay in payments) {
                ShowPayment(pay);
            }

        }

        private static void ShowPayment(Payment payment) {
            Console.WriteLine($"Payment => Name: {payment.HolderName},\t Card: {payment.CardNumber},\t Amount: {payment.AmountToPay}");
        }

        private static List<Payment> CreatePayments(int numberOfPayments) {

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
