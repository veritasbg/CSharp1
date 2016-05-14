using System;


namespace DecimalToHex
{
    class DecimalToHex
    {
        static void Main()
        {
            long decimalNumber = long.Parse(Console.ReadLine());

            //Console.WriteLine(decimalNumber.ToString("X"));
            //Console.WriteLine("{0:X}", decimalNumber);
            //Console.WriteLine(Convert.ToString(decimalNumber, 16).ToUpper());

            if (decimalNumber == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                string hexaNumber = "";   // other way: string hexaNumber = null;         
                while (decimalNumber > 0)
                {
                    // must be long; when this type is int the result is wrong
                    long checkRemainder = decimalNumber % 16;
                    string remainder = "";
                    switch (checkRemainder)
                    {
                        case 10: remainder = "A"; break;
                        case 11: remainder = "B"; break;
                        case 12: remainder = "C"; break;
                        case 13: remainder = "D"; break;
                        case 14: remainder = "E"; break;
                        case 15: remainder = "F"; break;
                        default: remainder = checkRemainder.ToString(); break;
                    }
                    hexaNumber = remainder + hexaNumber;
                    decimalNumber /= 16;
                }

                Console.WriteLine(hexaNumber);
            }
        }
    }
}