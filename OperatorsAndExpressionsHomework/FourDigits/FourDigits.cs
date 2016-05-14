using System;

namespace FourDigits
{
    class FourDigits
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
           
            uint digit4 = number % 10;
            uint digit3 = number / 10 % 10;
            uint digit2 = number / 100 % 10;
            uint digit1 = number / 1000;

            Console.WriteLine(digit1 + digit2 + digit3 + digit4);

            Console.WriteLine("{3}{2}{1}{0}", digit1, digit2, digit3, digit4);

            Console.WriteLine("{3}{0}{1}{2}", digit1, digit2, digit3, digit4);

            Console.WriteLine("{0}{2}{1}{3}", digit1, digit2, digit3, digit4);
        }
    }
}
  
