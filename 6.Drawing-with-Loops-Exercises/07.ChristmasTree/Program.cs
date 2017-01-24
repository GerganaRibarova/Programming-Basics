using System;

namespace _07.ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for(int i = 0; i <= n; i ++)
            {
                for(int ent = 1; ent <= n - i; ent ++)
                {
                    Console.Write(" ");
                }

                for(int stars  = 1; stars <= i; stars ++)
                {
                    Console.Write("*");
                }

                Console.Write(" | ");

                for (int stars = 1; stars <= i; stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
