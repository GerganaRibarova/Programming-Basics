using System;

namespace _11.Increasing4Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if ((num2 - num1) < 3)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = num1; i <= num2 - 3; i++)
                {

                    for (int j = num1 + 1; j <= num2 - 2; j++)
                        if (j > i)
                        {

                            for (int k = num1 + 2; k <= num2 - 1; k++)
                                if (k > j)
                                {

                                    for (int l = num1 + 3; l <= num2; l++)
                                        if (l > k)
                                        {
                                            Console.Write("{0} ", i);
                                            Console.Write("{0} ", j);
                                            Console.Write("{0} ", k);
                                            Console.WriteLine("{0}", l);
                                        }
                                }
                        }
                }
            }
        }
    }
}
