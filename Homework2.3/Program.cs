
/*Потрібно створити клас Employee. 
 * У тілі класу створити користувальницький конструктор, який приймає два рядкові аргументи, та ініціалізує поля, 
 * що відповідають прізвищу та імені співробітника.
 * Створити метод, що розраховує оклад співробітника (залежно від посади та стажу) та податковий збір. 
 * Написати програму, яка виводить на екран інформацію про співробітника (прізвище, ім'я, посада), оклад та податковий збір. */


namespace Homework2._3
{
    


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the name of employee: ");
            string name1 = Console.ReadLine();

            Console.Write("enter the surname of employee: ");
            string surname1 = Console.ReadLine();

            Console.Write("enter the position of employee (director or worker: ");
            string position = Console.ReadLine();

            Console.Write("enter the seniority of employee: ");
            double seniority = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"name: {name1}");
            Console.WriteLine($"surname: {surname1}");
            Console.WriteLine($"position: {position}");


            Employee employee = new Employee ();

            employee.Method(position, seniority);

            Console.ReadLine();

           
        }
    }
}

