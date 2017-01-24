using System;

namespace _06.Sum3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int max = a;
            if (max < b) max = b;
            if (max < c) max = c;

            if(a == max)
            {
                if (b + c == a)
                {
                    if (b < c) Console.WriteLine(b + " + " + c + " = " + a);
                    else Console.WriteLine(c + " + " + b + " = " + a);
                }
                else Console.WriteLine("No");
            }
            else if(b == max)
            {
                if (a + c == b)
                {
                    if (a < c) Console.WriteLine(a + " + " + c + " = " + b);
                    else Console.WriteLine(c + " + " + a + " = " + b);
                }
                else Console.WriteLine("No");
            }
            else
            {
                if (b + a == c)
                {
                    if (b < a) Console.WriteLine(b + " + " + a + " = " + c);
                    else Console.WriteLine(a + " + " + b + " = " + c);
                }
                else Console.WriteLine("No");
            }
        }
    }
}
