using System;

namespace _08.TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double s = double.Parse(Console.ReadLine());
            double price = -1;
            if (town == "sofia")
            {
                if (s >= 0 && s <= 500) price = s * 5 / 100;
                else if (s > 500 && s <= 1000) price = s * 7 / 100;
                else if (s > 1000 && s <= 10000) price = s * 8 / 100;
                else if (s > 10000) price = s * 12 / 100;
            }
            else if (town == "varna")
            {
                if (s >= 0 && s <= 500) price = s * 4.5 / 100;
                else if (s > 500 && s <= 1000) price = s * 7.5 / 100;
                else if (s > 1000 && s <= 10000) price = s * 10 / 100;
                else if (s > 10000) price = s * 13 / 100;
            }
            else if (town == "plovdiv")
            {
                if (s >= 0 && s <= 500) price = s * 5.5 / 100;
                else if (s > 500 && s <= 1000) price = s * 8 / 100;
                else if (s > 1000 && s <= 10000) price = s * 12 / 100;
                else if (s > 10000) price = s * 14.5 / 100;
            }

            if (price == -1) Console.WriteLine("error");
            else Console.WriteLine(Math.Round(price, 2));
        }
    }
}
