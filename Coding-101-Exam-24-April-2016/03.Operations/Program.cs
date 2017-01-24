using System;

namespace _03.Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            char s = char.Parse(Console.ReadLine());
            double result = 0;
            if(s == '+' || s =='-' || s == '*')
            {
                string type;
                if (s == '+') result = a + b;
                if (s == '-') result = a - b;
                if (s == '*') result = a * b;
                if (result % 2 == 0) type = "even";
                else type = "odd";
                Console.WriteLine("{0} {1} {2} = {3} - {4}", a, s, b, result, type);
            }
            else if(s == '/')
            {
                if(b == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", a);
                }
                else
                {
                    result = Math.Round(a / b, 2);
                    Console.WriteLine("{0} / {1} = {2}", a, b, result);
                }
            }
            else
            {
                if(b == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", a);
                }
                else
                {
                    result = a % b;
                    Console.WriteLine("{0} % {1} = {2}", a, b, result);
                }
            }
        }
    }
}
