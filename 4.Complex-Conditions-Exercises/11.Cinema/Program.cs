using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double price = -1;

            if(type == "premiere")
            {
                price = r * c * 12;
            }
            if(type == "normal")
            {
                price = r * c * 7.5;
            }
            if(type == "discount")
            {
                price = r * c * 5;
            }

            Console.WriteLine(Math.Round(price, 2) + " leva");
        }
    }
}
