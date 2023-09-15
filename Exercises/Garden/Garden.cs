using System;

namespace Garden
{
    class Garden
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double a1 = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double c1 = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double d1 = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double e1 = double.Parse(Console.ReadLine());
            double f = double.Parse(Console.ReadLine());

            double totalSum = a * 0.5 + b * 0.4 + c * 0.25 + d * 0.6 + e * 0.3 + f * 0.4;
            Console.WriteLine("Total costs: {0:F2}", totalSum);
            double seededArea = a1 + b1 + c1 + d1 + e1;

            if (seededArea < 250)
            {
                Console.WriteLine("Beans area: {0}", 250 - seededArea);
            }
            else
            {
                if (seededArea == 250)
                {
                    Console.WriteLine("No area for beans");
                }

                else if(seededArea > 250)
                {
                    Console.WriteLine("Insufficient area");
                }
            }
        }
    }
}