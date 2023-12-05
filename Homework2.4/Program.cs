
/*Створити клас Invoice. 
 * У тілі класу створити три поля int account, string customer, string provider, які мають бути проініціалізовані один раз 
 * (при створенні екземпляра даного класу) без можливості їхньої подальшої зміни. 
 * У тілі класу створити два закриті поля string article, int quantity Створити метод розрахунку вартості замовлення з ПДВ та без ПДВ. 
 * Написати програму, яка виводить на екран суму оплати замовленого товару з ПДВ чи без ПДВ.*/

using System.Threading.Channels;

namespace Homework2._4
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice price = new Invoice();

            price.Result("sugar", 30);

            Console.ReadKey();

        }
    }
}

