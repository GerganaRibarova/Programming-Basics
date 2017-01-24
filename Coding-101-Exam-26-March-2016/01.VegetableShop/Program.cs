using System;

namespace _01.VegetableShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceVeg = double.Parse(Console.ReadLine());
            var priceFruit = double.Parse(Console.ReadLine());
            var kgVeg = int.Parse(Console.ReadLine());
            var kgFruit = int.Parse(Console.ReadLine());

            var vegetables = priceVeg * kgVeg;
            var fruits = priceFruit * kgFruit;
            double sum = vegetables + fruits;
            Console.WriteLine(sum / 1.94);
        }
    }
}
