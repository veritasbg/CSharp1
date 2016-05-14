using System;
using System.Numerics;

namespace CalculateAgain
{
    class CalculateAgain
    {
        static void Main()
        {
            BigInteger numberN = BigInteger.Parse(Console.ReadLine());
            BigInteger numberK = BigInteger.Parse(Console.ReadLine());

            BigInteger division = 1;

            /// N!=1*2*3..*K...*N and  K! = 1*2*3.....*K
            /// N!/K! = 1*2*3..*K*(K+1)...*N/1*2*3.....*K = (K+1)*(K+2)..*N
            for (BigInteger i = numberK + 1; i <= numberN; i++)
            {
                division *= i;
            }

            Console.WriteLine(division);

        }

    }
}

