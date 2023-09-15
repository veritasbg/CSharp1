using System;

namespace CoffeeVendingMachine
{
    class CoffeeVendingMachine
    {
        static void Main()
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            double N3 = double.Parse(Console.ReadLine());
            double N4 = double.Parse(Console.ReadLine());
            double N5 = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());

            double sum = 0.05 * N1 + 0.10 * N2 + 0.20 * N3 + 0.50 * N4 + N5;
            double change = A - P;
            if (P>A)
            {
                Console.WriteLine("More {0:F2}",P-A);
            }
            else if(P<=A && sum>=A)
            {
                Console.WriteLine("Yes {0:F2}" ,(sum+P-A));
            }
            else if(sum+P<A)
            {
                Console.WriteLine("No {0:F2} ",A-(sum+P));
            }
        }
    }
}
