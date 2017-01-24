using System;

namespace _04.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int treated = 0;
            int untreated = 0;
            int doctors = 7;
            for(int i = 0; i < n; i++)
            {
                int patients = int.Parse(Console.ReadLine());
                if (patients >= doctors)
                {
                    treated += doctors;
                    untreated += treated - doctors;
                }
                else treated += patients;
                
                if (i % 3 == 0 && treated < untreated) doctors++;
            }
            Console.WriteLine("Treated patients: {0}", treated);
            Console.WriteLine("Untreatedpatients: {0}", untreated);
        }
    }
}
