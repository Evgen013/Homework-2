
/*Створити клас User, що містить інформацію про користувача (логін, ім'я, прізвище, вік, дату заповнення анкети).
 * Поле дата заповнення анкети має бути проініціалізоване лише один раз 
 * (при створенні екземпляра цього класу) без можливості його подальшої зміни. 
 * Реалізуйте виведення на екран інформації про користувача.*/

namespace Homework2._6
{
    class User
    {
        
        public string Login {  get; set; }
       
        public string Name { get; set; }
       
        public string Surname { get; set; }
        
        public int Age { get; set; }
   
        public DateTime Created { get; set; }
  
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User()
            {
                Login = "pro",
                Name = "Evgen",
                Surname = "Pash",
                Age = 32
            };
            DateTime dateTime = DateTime.Now;

            Console.WriteLine($"login: {user.Login}");
            Console.WriteLine($"name: {user.Name}");
            Console.WriteLine($"surname: {user.Surname}");
            Console.WriteLine($"age: {user.Age}");
            Console.WriteLine(dateTime);


            Console.ReadKey();
        }
    }
}

