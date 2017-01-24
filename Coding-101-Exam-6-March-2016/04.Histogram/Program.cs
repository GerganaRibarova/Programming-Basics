using System;

namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                var a = int.Parse(Console.ReadLine());
                if (a < 200) p1++;
                else if (a >= 200 && a <= 399) p2++;
                else if (a >= 400 && a <= 599) p3++;
                else if (a >= 600 && a <= 799) p4++;
                else if (a >= 800) p5++;
            }

            p1 = p1 * 100.0 / n;
            p2 = p2 * 100.0 / n;
            p3 = p3 * 100.0 / n;
            p4 = p4 * 100.0 / n;
            p5 = p5 * 100.0 / n;

            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
            Console.WriteLine("{0:f2}%", p4);
            Console.WriteLine("{0:f2}%", p5);
        }
    }
}
