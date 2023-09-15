using System;


namespace AngryFemaleGPS
{
    class AngryFemaleGPS
    {
        static void Main()
        {
            long N = long.Parse(Console.ReadLine());
            N = Math.Abs(N);

            long sumEvenDigits = 0;
            long sumOddDigits = 0;

            while (N > 0)
            {

                long digit = N % 10;
                if (digit % 2 == 0)
                {

                    sumEvenDigits += digit;
                    N /= 10;
                }
                else
                {
                    sumOddDigits += digit;
                    N /= 10;
                }

            }

            if (sumEvenDigits > sumOddDigits)
            {
                Console.WriteLine("right {0}", sumEvenDigits);
            }
            else if (sumOddDigits > sumEvenDigits)
            {
                Console.WriteLine("left {0}", sumOddDigits);
            }
            else
            {
                Console.WriteLine("straight {0}", sumEvenDigits);
            }


        }
    }
}
