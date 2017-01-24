using System;

namespace _07.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int sum = a + b + c;

            if(sum < 60)
            {
                if (sum < 10) Console.WriteLine("0:0" + sum);
                else Console.WriteLine("0:" + sum);
            }
            else if (sum >= 60 && sum <= 119)
            {
                sum = sum - 60;
                if (sum < 10) Console.WriteLine("1:0" + sum);
                else Console.WriteLine("1:" + sum);
            }
            else
            {
                sum = sum - 120;
                if (sum < 10) Console.WriteLine("2:0" + sum);
                else Console.WriteLine("2:" + sum);
            }
        }
    }
}
