using System;


namespace Interval
{
    class Interval
    {
        static void Main()
        {
            int numberN = int.Parse(Console.ReadLine());
            int numberM = int.Parse(Console.ReadLine());
            int amountDivisibleBy5 = 0;

            for (int i = numberN + 1; i < numberM; i++)
            {
                if (i % 5 == 0)
                {
                    amountDivisibleBy5++;
                }
            }

            Console.WriteLine(amountDivisibleBy5);
        }
    }
}
