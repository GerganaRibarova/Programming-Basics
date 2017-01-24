using System;

namespace _07.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            double price = 0;

            if(day == "monday" || day == "tuesday" || day == "wednesday"
                || day == "thursday" || day == "friday")
            {
                switch(fruit)
                {
                    case "banana":
                        price = 2.50 * quantity;
                        Console.WriteLine(Math.Round(price, 2)); break;
                    case "apple":
                        price = 1.20 * quantity;
                        Console.WriteLine(Math.Round(price, 2)); break;
                    case "orange":
                        price = 0.85 * quantity;
                        Console.WriteLine(Math.Round(price, 2)); break;
                    case "grapefruit":
                        price = 1.45 * quantity;
                        Console.WriteLine(Math.Round(price, 2)); break;
                    case "kiwi":
                        price = 2.70 * quantity;
                        Console.WriteLine(Math.Round(price, 2)); break;
                    case "pineapple":
                        price = 5.50 * quantity;
                        Console.WriteLine(Math.Round(price, 2)); break;
                    case "grapes":
                        price = 3.85 * quantity;
                        Console.WriteLine(Math.Round(price, 2)); break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else if(day == "saturday" || day == "sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.70 * quantity;
                        Console.WriteLine(Math.Round(price, 2)); break;
                    case "apple":
                        price = 1.25 * quantity;
                        Console.WriteLine(Math.Round(price, 2)); break;
                    case "orange":
                        price = 0.90 * quantity;
                        Console.WriteLine(Math.Round(price, 2)); break;
                    case "grapefruit":
                        price = 1.60 * quantity;
                        Console.WriteLine(Math.Round(price, 2)); break;
                    case "kiwi":
                        price = 3.00 * quantity;
                        Console.WriteLine(Math.Round(price, 2)); break;
                    case "pineapple":
                        price = 5.60 * quantity;
                        Console.WriteLine(Math.Round(price, 2)); break;
                    case "grapes":
                        price = 4.20 * quantity;
                        Console.WriteLine(Math.Round(price, 2)); break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }     

        }
    }
}
