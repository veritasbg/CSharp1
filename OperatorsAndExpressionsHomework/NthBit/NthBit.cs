using System;


namespace NthBit
{
    class NthBit
    {
        static void Main(string[] args)
        {
            long p = long.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            if (((p >> n) & 1) == 1)
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

