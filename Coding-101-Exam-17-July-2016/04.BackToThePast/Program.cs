using System;

namespace _04.BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            double razhodi = 0;

            for(int i = 1800; i<=year; i++)
            {
                if (i % 2 == 0)
                {
                    razhodi += 12000;
                    year++;
                }
                else
                {
                    year++;
                    razhodi += 12000 + 50 * year;
                }
            }

            if(money >= razhodi)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", money - razhodi);
            }
            else
            {
                Console.WriteLine("He will need {0:F2} dollars to survive.", razhodi - money);
            }
        }
    }
}
