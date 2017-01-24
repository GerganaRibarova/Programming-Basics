using System;

namespace _13.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = 0 ;
            string input = Console.ReadLine();


            if (input == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = Math.Pow(a, 2);
            }
            if(input == "rectangle")
            {
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                area = b * c;

            }
            if(input == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI * Math.Pow(r, 2);
            }
            if(input == "triangle")
            {
                double x = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                area = x * h / 2;

            }
            Console.WriteLine(Math.Round(area,3));
        }   
    }
}
