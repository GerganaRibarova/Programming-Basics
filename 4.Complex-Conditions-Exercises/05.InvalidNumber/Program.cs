using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            if (num < 100 || num > 200)
            {
                if(num != 0) Console.WriteLine("invalid");
            }
        }
    }
}
