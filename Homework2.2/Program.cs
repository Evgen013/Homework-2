

/*Створити клас Converter.У тілі класу створити користувальницький конструктор, який приймає три речові аргументи, 
 * і ініціалізує поля, що відповідають курсу 3-х основних валют, по відношенню до гривні – public Converter (double usd, double eur, double rub). 
 * Написати програму, яка виконуватиме конвертацію з гривні в одну із зазначених валют, 
 * також програма повинна проводити конвертацію із зазначених валют у гривню. */


namespace Homework2._2
{
    
        internal class Program
        {
            static void Main()
            {
                Console.Write("enter the amount of money : ");
                double griv = Convert.ToDouble(Console.ReadLine());

                Console.Write("enter the current EUR or USD: ");
                string cur = Console.ReadLine();

                Converter converter = new Converter();

                converter.Method(griv, cur);

                Console.ReadKey();
            }
        }
}


