using System;

namespace _10.AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine().ToLower();
            if (animal == "dog") Console.WriteLine("mammal");
            else if (animal == "crocodile" || animal == "tortoise"
                || animal == "snake") Console.WriteLine("reptile");
            else Console.WriteLine("unknown");
        }
    }
}
