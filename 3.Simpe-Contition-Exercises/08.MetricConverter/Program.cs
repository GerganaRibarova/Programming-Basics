using System;

namespace _08.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {

            double mm = 1000;
            double cm = 100;
            double mi = 0.000621371192;
            double inc = 39.3700787;
            double km = 0.001;
            double ft = 3.2808399;
            double yd = 1.0936133;

            double distance = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            switch (input)
            {
                case "mm": distance /= mm; break;
                case "cm": distance /= cm; break;
                case "mi": distance /= mi; break;
                case "in": distance /= inc; break;
                case "km": distance /= km; break;
                case "ft": distance /= ft; break;
                case "yd": distance /= yd; break;
            }

            switch (output)
            {
                case "mm": distance *= mm; break;
                case "cm": distance *= cm; break;
                case "mi": distance *= mi; break;
                case "in": distance *= inc; break;
                case "km": distance *= km; break;
                case "ft": distance *= ft; break;
                case "yd": distance *= yd; break;
            }

            Console.WriteLine(distance + " " + output);
        }
    }
}
