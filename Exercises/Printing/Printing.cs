using System;

namespace Printing
{
    class Printing
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double s = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
           // double realm = 500;

            double neededPaper = n * s;
            double realmsNeeded = (n * s) / 500;
            double moneysaved = realmsNeeded * p;
            Console.WriteLine("{0:F2}", moneysaved);

        }
    }
}
