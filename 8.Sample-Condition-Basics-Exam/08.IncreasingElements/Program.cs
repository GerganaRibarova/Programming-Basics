using System;

namespace _08.IncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for(int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int currSeq = 0;
            int maxSeq = 0;

            for (int i = 1; i < n; i++)
            {
                if (numbers[i] - numbers[i - 1] >= 1)
                {
                    currSeq++;

                    if (currSeq > maxSeq)
                    {
                        maxSeq = currSeq;
                    }
                }
                else
                {
                    currSeq = 0;
                }
            }

            Console.WriteLine(maxSeq + 1);
        }
    }
}
