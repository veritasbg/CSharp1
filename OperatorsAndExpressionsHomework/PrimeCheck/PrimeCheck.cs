using System;

namespace PrimeCheck
{
    class PrimeCheck
    {
        static void Main()
        {
            {
                int input = int.Parse(Console.ReadLine());
                bool Prime = true;

                if (input <= 1)
                {
                    Console.WriteLine("false");
                    return;
                }

                for (int i = 2; i < input; i++)
                {
                    if ((input % i) == 0)
                    {
                        Prime = false;
                    }
                }

                if (Prime || input == 2)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
        