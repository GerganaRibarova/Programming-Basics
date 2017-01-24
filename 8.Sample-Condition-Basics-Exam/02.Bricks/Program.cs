using System;

namespace _02.Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());

            double course = x / (w * m);
            Console.WriteLine(course);
            Console.WriteLine(Math.Ceiling(course));
        }
    }
}
