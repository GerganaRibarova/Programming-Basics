using System;

namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int starsInRoof = 0;
            if (n % 2 == 0) starsInRoof = 2;
            else starsInRoof = 1;

            int dashesInRoof = 0;
            if (n % 2 == 0) dashesInRoof = (n - 1) / 2;
            else dashesInRoof = n / 2;

            for(int i = 1; i <= (n + 1) / 2; i ++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('-', dashesInRoof),
                    new string('*', starsInRoof));
                starsInRoof += 2;
                dashesInRoof--;
            }

            int rows = 0;

            for(int i=1; i <= n / 2; i++)
            {
               Console.WriteLine("{0}{1}{0}",
                  '|', new string('*', n - 2));
            }
        }
    }
}
