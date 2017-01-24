using System;

namespace _03.TimeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var hourTest = int.Parse(Console.ReadLine());
            var minTest = int.Parse(Console.ReadLine());
            var hourSt = int.Parse(Console.ReadLine());
            var minSt = int.Parse(Console.ReadLine());

            var ExamTime = hourTest * 60 + minTest;
            var StudentTime = hourSt * 60 + minSt;
            
            if(StudentTime > ExamTime)
            {
                Console.WriteLine("Late");
                var late = StudentTime - ExamTime;
                if(late < 60)
                {
                    Console.WriteLine("{0} minutes after the start", late);
                }
                else
                {
                    int hour = late / 60;
                    int min = late - hour * 60;
                    if (min > 9) Console.WriteLine("{0}:{1} hours after the start", hour, min);
                    else Console.WriteLine("{0}:0{1} hours after the start", hour, min);
                }
                
            }
            else if(StudentTime == ExamTime || StudentTime + 30 >= ExamTime)
            {
                Console.WriteLine("On time");
                var onTime = ExamTime - StudentTime;
                if(onTime != 0)
                {
                    if (onTime < 60)
                     {
                         Console.WriteLine("{0} minutes before the start", onTime);
                     }
                    else
                     {
                         if (onTime > 9) Console.WriteLine("{0} minutes before the start", onTime);
                         else Console.WriteLine("{0} minutes before the start", onTime);
                     }
                }
                
            }
            else
            {
                Console.WriteLine("Early");
                var early = ExamTime - StudentTime;
                if (early < 60)
                {
                    Console.WriteLine("{0} minutes before the start", early);
                }
                else
                {
                    int hour = early / 60;
                    int min = early - hour * 60;
                    if (min > 9) Console.WriteLine("{0}:{1} hours before the start", hour, min);
                    else Console.WriteLine("{0}:0{1} hours before the start", hour, min);
                }
            }
        }
    }
}
