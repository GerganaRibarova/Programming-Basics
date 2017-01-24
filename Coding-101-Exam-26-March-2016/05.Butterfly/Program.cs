using System;

namespace _05.Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int col = 2 * n - 1;
            int rows = 2 * (n - 2) + 1;
            int w = n - 1;

            for(int i = 1; i <= rows/2; i++)
            {
                if (i % 2 != 0) Console.WriteLine("{0}\u005c /{0}",
                     new string('*', w - 1));
                else Console.WriteLine("{0}\u005c /{0}",
                     new string('-', w - 1));
            }
            Console.WriteLine("{0}{1}", new string(' ', w), '@');
            for(int i = 1; i <= rows/2; i++)
            {
                if (i % 2 != 0) Console.WriteLine("{0}/ \u005c{0}",
                     new string('*', w - 1));
                else Console.WriteLine("{0}/ \u005c{0}",
                     new string('-', w - 1));
            }
        }
    }
}
