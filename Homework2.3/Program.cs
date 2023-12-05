
/*Потрібно створити клас Employee. 
 * У тілі класу створити користувальницький конструктор, який приймає два рядкові аргументи, та ініціалізує поля, 
 * що відповідають прізвищу та імені співробітника.
 * Створити метод, що розраховує оклад співробітника (залежно від посади та стажу) та податковий збір. 
 * Написати програму, яка виводить на екран інформацію про співробітника (прізвище, ім'я, посада), оклад та податковий збір. */


namespace Homework2._3
{
    class Employee
    {
        private string name;
        private string surname;
        private string position;
        private double seniority;


        public string Name
        {
            get { return name; }
        }
        public string Surname
        {
            get { return surname; }
        }

        public void Method(string position, double seniority)
        {
            double totalPosition = 0;
            double totalSeniority = 0;

            switch (position)
            {
                case "director":
                    totalPosition = 2000;
                    break;

                case "worker":
                    totalPosition = 1000;
                    break;

            }

            if (seniority > 3)
            {
                totalSeniority = 5;
            }
            else
            {
                totalSeniority = 2;
            }

            double totalSalary = totalPosition * totalSeniority;  

            Console.WriteLine($"total salary is: {totalSalary}");

            double taxCollection = totalSalary * 1 / 6;

            Console.WriteLine($"tax collection: {taxCollection}");
        }
    }


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

