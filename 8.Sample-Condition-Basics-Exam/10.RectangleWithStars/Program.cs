using System;

namespace _10.RectangleWithStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var rows = (Math.Ceiling(num / 2.0) - 1);
            var ands = new string('%', num * 2);
            var space = new string(' ', num * 2 - 2);
            var spaceMiddle = new string(' ', (num * 2 - 4) / 2);

            Console.WriteLine(ands);
            for (int i = 0; i < rows; i++)
            {
                Console.Write("%");
                Console.Write(space);
                Console.WriteLine("%");
            }
            Console.Write("%");
            Console.Write(spaceMiddle);
            Console.Write("**");
            Console.Write(spaceMiddle);
            Console.WriteLine("%");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("%");
                Console.Write(space);
                Console.WriteLine("%");
            }
            Console.WriteLine(ands);
        }
    }
}
