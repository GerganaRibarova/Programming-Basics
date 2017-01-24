using System;

namespace _05.Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int brDashes = n * 2 + 1;
            //First row
            Console.WriteLine("{0}{1}{0}",
                new string('.', n + 1), new string('_', brDashes + 2));

            // Middle up
            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine("{0}//{1}\\\\{0}",
                    new string('.', i), new string('_', brDashes));
                brDashes += 2;
            }
            brDashes = (brDashes - 5) / 2;

            //STOP row
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', brDashes));

            //Middle down
            brDashes = brDashes * 2 + 5;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}",
                    new string('.', i), new string('_', brDashes));
                brDashes -= 2;
            }
        }
    }
}
