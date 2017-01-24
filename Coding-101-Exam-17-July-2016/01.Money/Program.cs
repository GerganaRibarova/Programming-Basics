using System;

namespace _01.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitkoin = 1168;
            double yan = 0.15 * 1.76;
            double dolar = 1.76;
            double euro = 1.95;

            int brbitkoin = int.Parse(Console.ReadLine());
            double brYan = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double sum = brbitkoin * bitkoin + brYan * yan;
            sum = sum / euro;
            double komisionna = sum * percent / 100;
            Console.WriteLine(sum - komisionna);

        }
    }
}
