using System;


namespace FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            int a;
            // parsing and input check (validating the user data)
            while (!int.TryParse(Console.ReadLine(), out a) || a < 0 || a > 500)
            {
                Console.WriteLine("Invalid number.");
                Console.Write("Please enter a correct integer number a (0 <= a <= 500)  a = ");
            }

            double b, c;
            while (!double.TryParse(Console.ReadLine(), out b)) // parsing and input check 
            {
                Console.WriteLine("Invalid number.");
                Console.Write("Please enter a correct floating-point number b = ");
            }
            while (!double.TryParse(Console.ReadLine(), out c)) // parsing and input check
            {
                Console.WriteLine("Invalid number.");
                Console.Write("Please enter a correct floating-point number c = ");
            }

            // printed in hexadecimal, left aligned| then - in binary form, padded with zeroes 
            Console.Write("{0,-10:X}|{1}", a, Convert.ToString(a, 2).PadLeft(10, '0'));

            // printed with 2 digits after the decimal point, right aligned  
            Console.Write("|{0,10:0.00}", b);

            // printed with 3 digits after the decimal point, left aligned
            Console.WriteLine("|{0,-10:0.000}|", c);
        }
    }
}
