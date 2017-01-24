using System;


namespace _12.GenerateRectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());

            if ((4 * input1 * input1) < input2)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int left = -input1; left <= input1; left++)
                {
                    for (int top = -input1; top <= input1; top++)
                    {
                        for (int right = -input1; right <= input1; right++)
                        {
                            if (right > left)
                            {
                                for (int bottom = -input1; bottom <= input1; bottom++)
                                {
                                    if (bottom > top)
                                    {
                                        int side1 = left - right;
                                        int side2 = top - bottom;
                                        int area = side1 * side2;
                                        if (area >= input2)
                                        {
                                            Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", left, top, right, bottom, area);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
