using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var leva = 1.0;
            var dollar = 1.79549;
            var euro = 1.95583;
            var pound = 2.53405;

            var value = double.Parse(Console.ReadLine());
            string inputVal = Console.ReadLine();
            string outputVal = Console.ReadLine();

            switch (inputVal)
            {
                case "BGN":
                    break;
                case "USD":
                    value = (value * dollar);
                    break;
                case "EUR":
                    value = (value * euro);
                    break;
                case "GBP":
                    value = (value * pound);
                    break;
                default:
                    break;
            }

            switch (outputVal)
            {
                case "BGN":
                    value = value / leva;
                    break;
                case "USD":
                    value = value / dollar;
                    break;
                case "EUR":
                    value = value / euro;
                    break;
                case "GBP":
                    value = value / pound;
                    break;
                default:
                    break;
            }

            Console.WriteLine(Math.Round(value, 2) + " " + outputVal);
        }
    }
}
