using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
