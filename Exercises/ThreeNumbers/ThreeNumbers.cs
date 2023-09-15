using System;


namespace ThreeNumbers
{
    class ThreeNumbers
    {
        static void Main()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(C,(Math.Max(A, B))));
            Console.WriteLine(Math.Min(C, (Math.Min(A, B))));

            double arithmeticMean = (A + B + C) / 3.00;

            Console.WriteLine("{0:F2}",arithmeticMean);
        }
    }
}
