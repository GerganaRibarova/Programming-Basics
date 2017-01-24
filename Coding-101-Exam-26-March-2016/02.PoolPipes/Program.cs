using System;

namespace _02.PoolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = int.Parse(Console.ReadLine());
            var p1 = int.Parse(Console.ReadLine());
            var p2 = int.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());

            double sum = p1 * hours + p2 * hours;
            if(sum <= v)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                Math.Truncate(sum / v * 100),
                Math.Truncate(p1 * hours / sum * 100),
                Math.Truncate(p2 * hours / sum * 100));
            }
            else
            {
                double dif = sum - v;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, dif);
            }
        }
    }
}
