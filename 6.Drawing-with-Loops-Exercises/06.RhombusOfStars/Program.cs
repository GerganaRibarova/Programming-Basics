using System;

namespace _06.RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                for(int ent = 1; ent <= n - i; ent ++)
                {
                    Console.Write(" ");
                }

                for(int star = 1; star <= i; star ++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for(int i = 1; i <= n - 1; i ++)
            {
                for(int ent = 1; ent <= i; ent++)
                {
                    Console.Write(" ");
                }
                for(int star = n-1; star >= i; star --)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
                
        }
    }
}
