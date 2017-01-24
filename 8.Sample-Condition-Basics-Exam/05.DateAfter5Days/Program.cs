using System;

namespace _05.DateAfter5Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            d += 5;
            if ((m == 4 || m == 6 || m == 9 || m == 11) && d > 30)
            {
                d = d - 30;
                m++;
            }
            if (m == 2 && d > 28)
            {
                d = d - 28;
                m++;
            }
            if ((m == 1 || m == 3 || m == 5 || m == 7 || m == 8 ||
                m == 10 || m == 12) && d > 31)
            {
                d = d - 31;
                m++;
            }

            if (m == 13) m = 1;

            if (m >= 10) Console.WriteLine(d + "." + m);
            else Console.WriteLine(d + ".0" + m);
        }
    }
}
