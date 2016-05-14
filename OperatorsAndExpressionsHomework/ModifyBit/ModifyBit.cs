using System;


namespace ModifyBit
{
    class ModifyBit
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            int value = int.Parse(Console.ReadLine());

            //Console.WriteLine("Binary representation: " + Convert.ToString(number, 2).PadLeft(16, '0'));

            if (value == 0)
            {
                ulong mask = (ulong)~(1 << position);
                ulong result = number & mask;
                //Console.WriteLine("Modified value:        " + Convert.ToString(result, 2).PadLeft(16, '0'));      
                Console.WriteLine(result);
            }
            else
            {
                ulong mask = (ulong)1 << position;
                ulong result = number | mask;
                //Console.WriteLine("Modified value:        " + Convert.ToString(result, 2).PadLeft(16, '0'));
                Console.WriteLine(result);
            }
        }
    }
}
