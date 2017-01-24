using System;

namespace _03.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            int n = int.Parse(Console.ReadLine());
            double price = 0;
            double transport = 0;

            if(category == "vip")
            {
                price = 499.99;
            }
            else
            {
                price = 249.99;
            }

            if (n >= 1 && n <= 4) transport = budget * 0.75;
            else if (n >= 5 && n <= 9) transport = budget * 0.6;
            else if (n >= 10 && n <= 24) transport = budget * 0.5;
            else if (n >= 25 && n <= 49) transport = budget * 0.4;
            else transport = budget * 0.25;

            if(budget - transport*n >= price)
            {
                Console.WriteLine("Yes! You have {0} leva left.", Math.Round(budget - transport*n - price*n,2));
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0} leva.", Math.Round(price * n - (budget - transport * n),2));
            }
        }
    }
}
