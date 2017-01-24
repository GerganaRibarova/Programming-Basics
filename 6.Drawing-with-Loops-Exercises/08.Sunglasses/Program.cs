using System;

namespace _08.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 2 * n; i++)
            {
                Console.Write("*");
            }
            for(int ent = 1; ent <= n; ent ++)
            {
                Console.Write(" ");
            }
            for (int i = 1; i <= 2 * n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            for(int i = 1; i <= n - 2; i++)
            {
                Console.Write("*");
                for(int stars = 1; stars <= n * 2 - 2; stars ++)
                {
                    Console.Write("/");
                }
                Console.Write("*");
                if(i == (n-1) / 2)
                {
                    for(int sreda = 1; sreda <= n; sreda++)
                    {
                        Console.Write("|");
                    }
                }
                else
                {
                    for (int sreda = 1; sreda <= n; sreda++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("*");
                for (int stars = 1; stars <= n * 2 - 2; stars++)
                {
                    Console.Write("/");
                }
                Console.Write("*");
                Console.WriteLine();
            }

            for (int i = 1; i <= 2 * n; i++)
            {
                Console.Write("*");
            }
            for (int ent = 1; ent <= n; ent++)
            {
                Console.Write(" ");
            }
            for (int i = 1; i <= 2 * n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

        }
    }
}
