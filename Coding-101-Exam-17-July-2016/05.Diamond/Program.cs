using System;

namespace _05.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int br = 0;
            Console.WriteLine("{0}{1}{0}", new string('.', n),
                new string('*', n * 3));
            for(int i = n - 1; i >= 1; i--)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', i),
                    new string('.', n*3 + br));
                br += 2;
            }
            Console.WriteLine("{0}", new string('*', n * 5));
        }
    }
}
