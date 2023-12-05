using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._2
{
    class Converter
    {
        private int usd;
        private int eur;

        public int Usd
        {
            get { return usd; }
        }

        public int Eur
        {
            get { return eur; }
        }

        public void Method(double griv, string cur)
        {
            double result = 0;

            switch (cur)
            {
                case "usd":
                    result = griv * 38;
                    break;
                case "eur":
                    result = griv * 40;
                    break;

            }
            Console.WriteLine($" {griv} grivnius cost {result} {cur}");
        }
    }
}
