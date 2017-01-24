using System;

namespace _02.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var km = double.Parse(Console.ReadLine());
            string day = Console.ReadLine().ToLower();

            double taxi = -1.0;
            double bus = -1.0;
            double train = -1.0;

            if(day == "day")
            {
                taxi = 0.7 + km * 0.79;
                if (km >= 20) bus = km * 0.09;
                if (km >= 100) train = km * 0.06;
            }
            else if(day == "night")
            {
                taxi = 0.7 + km * 0.9;
                if (km >= 20) bus = km * 0.09;
                if (km >= 100) train = km * 0.06;
            }

            double min = taxi;
            if (min > bus && bus > -1) min = bus;
            if (min > train && train > -1) min = train;

            Console.WriteLine(min);

        }
    }
}
