using System;

namespace _3_6_9
{
    class Program
    {
        static void Main()
        {
            long A = long.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            long C = long.Parse(Console.ReadLine());

            long resultR = 0;
            if (B == 3)
            {
                resultR = A + C;
            }
            else if (B == 6)
            {
                resultR = A * C;
            }
            else if (B == 9)
            {
                resultR = A % C;
            }



            if (resultR % 3 == 0)
            {
                Console.WriteLine(resultR / 3);
               
            }
            else 
            {
                Console.WriteLine(resultR % 3);
               
            }
            Console.WriteLine(resultR);
        }
    }
}