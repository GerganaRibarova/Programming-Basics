using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows = n / 100 + n / 10 % 10;
            int cols = n / 100 + n % 10;
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= cols; j++)
                {
                    if (n % 5 == 0)
                    {
                        n = n - n / 100;
                        Console.Write(n + " ");
                    }
                    else if(n % 3 == 0)
                    {
                        n = n - n / 10 % 10;
                        Console.Write(n + " ");
                    }
                    else
                    {
                        n = n + n % 10;
                        Console.Write(n + " ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
