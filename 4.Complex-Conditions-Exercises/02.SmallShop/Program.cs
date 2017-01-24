using System;

namespace _02.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            double price = 0;

            if (town == "sofia")
            {
                switch (product)
                {
                    case "coffee": price = 0.50 * quantity; break;
                    case "water": price = 0.80 * quantity; break;
                    case "beer": price = 1.20 * quantity; break;
                    case "sweets": price = 1.45 * quantity; break;
                    case "peanuts": price = 1.60 * quantity; break;
                }
            }

            if (town == "plovdiv")
            {
                switch (product)
                {
                    case "coffee": price = 0.40 * quantity; break;
                    case "water": price = 0.70 * quantity; break;
                    case "beer": price = 1.15 * quantity; break;
                    case "sweets": price = 1.30 * quantity; break;
                    case "peanuts": price = 1.50 * quantity; break;
                }
            }

            if (town == "varna")
            {
                switch (product)
                {
                    case "coffee": price = 0.45 * quantity; break;
                    case "water": price = 0.70 * quantity; break;
                    case "beer": price = 1.10 * quantity; break;
                    case "sweets": price = 1.35 * quantity; break;
                    case "peanuts": price = 1.55 * quantity; break;
                }
            }

            Console.WriteLine(price);
        }
    }
}
