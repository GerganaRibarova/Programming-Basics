using System;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double br = 0;

             br += (48 - h) * 3.0 / 4;
             br += p * 2.0 / 3;
             br += h;

            if (year == "normal")
            {
                Console.WriteLine(Math.Truncate(br));
            }
            if(year == "leap")
            {
                br += br * 15 / 100;
                Console.WriteLine(Math.Truncate(br));
            }
        }
    }
}
