using System;

namespace _01.TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = double.Parse(Console.ReadLine()) * 100 ;
            var h = double.Parse(Console.ReadLine()) * 100 - 100;
            Console.WriteLine(w);
            Console.WriteLine(h);

            var numW = Math.Floor(w / 120);
            var numH = Math.Floor(h / 70);
            Console.WriteLine(numW);
            Console.WriteLine(numH);
            var seats = numH * numW - 3;
            Console.WriteLine(seats);
        }
    }
}
