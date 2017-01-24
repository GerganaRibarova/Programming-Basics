using System;

namespace _10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n <= 2)
            {
                for (int i = 1; i <= n; i++) Console.WriteLine("*");
            }

            int brStars = 0;
            if (n % 2 == 0) brStars = 2;
            else brStars = 1;

            int brDashesInside = brStars;

            int brDashes = 0;
            if (n % 2 == 0) brDashes = n / 2 - 1;
            else brDashes = n / 2;

            int rows = brDashes + 1;

            Console.WriteLine("{0}{1}{0}",
                new string('-', brDashes),
                new string('*', brStars));

            brDashes--;
            brStars = 1;

            for (int i = 1; i < rows ; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string('-', brDashes),
                    new string('*', brStars),
                    new String('-', brDashesInside));
                if (brStars > 1) brStars = 1;
                brDashes--;
                brDashesInside += 2;
            }



        }
    }
}
