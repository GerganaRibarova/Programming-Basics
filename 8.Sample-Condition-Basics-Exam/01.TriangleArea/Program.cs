using System;

namespace _01.TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = int.Parse(Console.ReadLine());
            var y1 = int.Parse(Console.ReadLine());
            var x2 = int.Parse(Console.ReadLine());
            var y2 = int.Parse(Console.ReadLine());
            var x3 = int.Parse(Console.ReadLine());
            var y3 = int.Parse(Console.ReadLine());

            double h = Math.Abs(y2 - y1);
            double a = Math.Abs(x2 - x3);
            double S = a * h / 2;
            Console.WriteLine(S);
        }
    }
}
