using System;

namespace _14.Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());
            mins += 15;

            if(mins < 60)
            {
                if (mins < 10) Console.WriteLine(hour + ":0" + mins);
                else Console.WriteLine(hour + ":" + mins);
            }
            else
            {
                mins -= 60;
                hour += 1;
                if(hour > 23)
                {
                    if (mins < 10) Console.WriteLine("0:0" + mins);
                    else Console.WriteLine("0:" + mins);
                }
                else
                {
                    if (mins < 10) Console.WriteLine(hour + ":0" + mins);
                    else Console.WriteLine(hour + ":" + mins);
                }
            }
        }
    }
}
