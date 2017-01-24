using System;

namespace _02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int rest = int.Parse(Console.ReadLine());
            int work = 365 - rest;
            int play = rest * 127 + work * 63;
            if(play > 30000)
            {
                Console.WriteLine("Tom will run away");
                int time = play - 30000;
                Console.WriteLine("{0} hours and {1} minutes more for play",
                    time / 60, time % 60);
            }
            else
            {
                int time = 30000 - play;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play",
                    time / 60, time % 60);
            }

        }
    }
}
