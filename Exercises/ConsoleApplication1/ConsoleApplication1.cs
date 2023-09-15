using System;
using System.Numerics;

namespace ConsoleApplication1
{
    class ConsoleApplication1
    {
        static void Main()
        {
            int index = 0;
            BigInteger globalProduct = 1;
            while (true)
            {
                var line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                if (index == 10)
                {
                    Console.WriteLine(globalProduct);
                    globalProduct = 1;
                }

                long num = long.Parse(Console.ReadLine());
                if (index % 2 == 1)
                {
                    long product = 1;
                    while (num > 10)
                    {
                        long digit = num % 10;
                        if (digit != 0)
                        {
                            product *= digit;
                        }
                        num /= 10;
                    }
                    globalProduct = globalProduct * globalProduct;
                }

                index = index + 1;
            }
            Console.WriteLine(globalProduct);
        }

    }
}

