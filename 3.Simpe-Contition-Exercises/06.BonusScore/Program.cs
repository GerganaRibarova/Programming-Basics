using System;

namespace _06.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            var points = double.Parse(Console.ReadLine());
            double bonus;
            double sum;
            if(points <= 100)
            {
                bonus = 5;
            }
            else if (points > 100 && points <=1000)
            {
                bonus = points * 20 / 100;
            }
            else
            {
                bonus = points * 10 / 100;
            }

            if(points % 2 == 0)
            {
                bonus += 1;
            }

            if(points % 10 == 5)
            {
                bonus += 2;
            }

            sum = points + bonus;

            Console.WriteLine(bonus);
            Console.WriteLine(sum);
        }
    }
}
