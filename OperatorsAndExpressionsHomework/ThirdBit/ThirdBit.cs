using System;

namespace ThirdBit
{
    class ThirdBit
    {
        static void Main()
        {
            uint input = uint.Parse(Console.ReadLine());

            if (((input >> 3) & 1) == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
   
