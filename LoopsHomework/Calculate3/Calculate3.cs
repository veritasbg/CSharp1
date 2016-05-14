using System;
using System.Numerics;

namespace Calculate3
{
    class Calculate3
    {
        static void Main()
        {
            //Console.Write("Enter an integer number n: 1 < n < 100   n= ");
            int n = int.Parse(Console.ReadLine());
            //Console.Write("Enter an integer number k: 1 < k < {0}   k= ", n);
            int k = int.Parse(Console.ReadLine());

            //if (1 < k && k < n && n < 100)
            //{

            BigInteger numerator = 1;
            BigInteger denominator = 1;

            for (int i = k + 1; i <= n; i++)
            {
                numerator *= i;
            }

            for (int j = 2; j <= (n - k); j++)
            {
                denominator *= j;
            }

            BigInteger result = numerator / denominator;
            Console.WriteLine(result);

            //}
            //else
            //{
            //    Console.WriteLine("Invalid input!");
            //}
        }
    }
}
