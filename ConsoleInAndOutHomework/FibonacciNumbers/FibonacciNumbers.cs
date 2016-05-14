using System;


namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            int lengthN = int.Parse(Console.ReadLine());

            long current;
            long previous = 1;
            long beforePrevious = 0;

            for (int i = 0; i < lengthN; i++)
            {
                if (i == 0)
                {
                    current = beforePrevious;
                }
                else if (i == 1)
                {
                    current = previous;
                }
                else
                {
                    current = beforePrevious + previous;
                    beforePrevious = previous;
                    previous = current;
                }

                if (i < lengthN - 1)
                {
                    Console.Write("{0}, ", current);
                }
                else
                {
                    Console.Write(current);
                    Console.WriteLine();
                }
            }
        }
    }
}
