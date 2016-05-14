using System;

class ThirdDigit
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());

        if (number < 100)
        {
            Console.WriteLine("false 0");
            return;
        }

        number /= 100;

        uint thirdDigit = number %= 10;

        if (thirdDigit == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false {0}", thirdDigit);
        }
    }
}

