using System;

namespace _05.DrawFort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int brRoof = n / 2;
            int brDashes = 0;
            if (n <= 4) Console.WriteLine("/" + new string('^', brRoof) + "\u005c/" + new string('^', brRoof) + "\u005c");
            else
            {
                brDashes = n / 2;
                Console.WriteLine("/" + new string('^', brRoof) + "\u005c" + new string('_', brDashes ) + "/" + new string('^', brRoof) + "\u005c");
            }

            var brEscape = brRoof * 2 + brDashes + 2;
            for(int i = 0; i < n - 3; i++)
            {
                Console.WriteLine("{0}{1}{0}", '|',
                    new string(' ', brEscape));
            }
            Console.WriteLine("\u005c" + new string('_', brRoof) + "/" + new string(' ', brDashes) + "\u005c" + new string('_', brRoof) + "/");
        }
    }
}
