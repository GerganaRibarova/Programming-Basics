using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            var years = int.Parse(Console.ReadLine());
            double peralnq = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int brtoys = 0;
            double money = 0;

            for(int i = 1; i <= years; i++)
            {
                if (i % 2 != 0) brtoys++;
                else
                {
                    money = money + i * 10 / 2;
                }
            }

            double moneyToys = toyPrice * brtoys;
            double savedMoney = money + moneyToys - years / 2;

            if (savedMoney >= peralnq) Console.WriteLine("Yes! {0:F2}", Math.Round(savedMoney - peralnq,2));
            else Console.WriteLine("No! {0:F2}", Math.Round(peralnq - savedMoney,2));
        }
    }
}
