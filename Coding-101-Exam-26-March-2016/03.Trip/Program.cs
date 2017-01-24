using System;

namespace _03.Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string destination;
            string type = "";
            if (money <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    money = money * 30 / 100;
                    type = "Camp";
                }
                else if (season == "winter")
                {
                    money = money * 70 / 100;
                    type = "Hotel";
                }
            }
            else if (money > 100 && money <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    money = money * 40 / 100;
                    type = "Camp";
                }
                else
                {
                    money = money * 80 / 100;
                    type = "Hotel";
                }
            }
            else
            {
                destination = "Europe";
                money = money * 90 / 100;
                type = "Hotel";
            }

                Console.WriteLine("Somewhere in {0}", destination);
                Console.WriteLine("{0} - {1:F2}", type, money);
            }
        }
    }
