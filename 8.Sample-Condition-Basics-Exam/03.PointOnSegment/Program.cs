using System;

namespace _03.PointOnSegment
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());
            int dif1 = Math.Abs(first - point);
            int dif2 = Math.Abs(second - point);

            if((point >= first && point <= second) || (point <= first && point >= second))
            {
                Console.WriteLine("in");
                if (dif1 < dif2) Console.WriteLine(dif1);
                else Console.WriteLine(dif2);
            }
            else
            {
                Console.WriteLine("out");
                if (dif1 < dif2) Console.WriteLine(dif1);
                else Console.WriteLine(dif2);
            }
        }
    }
}
