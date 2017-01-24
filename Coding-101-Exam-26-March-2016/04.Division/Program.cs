using System;

namespace _04.Division
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for(int i = 0; i < n; i++)
            {
                var a = int.Parse(Console.ReadLine());
                if (a % 2 == 0) p1++;
                if (a % 3 == 0) p2++;
                if (a % 4 == 0) p3++;
            }

            Console.WriteLine("{0:F2}%", p1 / n * 100);
            Console.WriteLine("{0:F2}%", p2 / n * 100);
            Console.WriteLine("{0:F2}%", p3 / n * 100);

        }
    }
}
