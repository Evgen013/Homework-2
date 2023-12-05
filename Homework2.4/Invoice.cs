using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._4
{
    class Invoice
    {
        private readonly int account = 313; //рахунок
        private readonly string customer = "EVGEN"; //клієнт
        private readonly string provider = "Maria"; //провайдер
        private string article; //стаття
        private int quantity;  //кількість

        public int Account
        { get { return account; } }

        public string Customer
        { get { return customer; } }

        public string Provider
        { get { return provider; } }



        public void Result(string article, int quantity)
        {
            double price1 = 0;

            switch (article)
            {
                case "coffee":
                    price1 = 40;
                    break;
                case "sugar":
                    price1 = 60;
                    break;


            }

            double result = price1 * quantity;
            double vat = result - (result * 1 / 6);

            Console.WriteLine($"price for {quantity} pieces of {article} with VAT is: {result}, without VAT is {vat} ");
        }
    }
}
