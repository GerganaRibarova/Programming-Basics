using System;

namespace _09.CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = double.Parse(Console.ReadLine());
            var f = c * 1.8 + 32;
            Console.WriteLine(Math.Round(f, 2));
            Console.ReadLine();
        }
    }
}
