using System;


namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter a binary number (consisted of 0 and 1): ");
            string binaryNumber = Console.ReadLine();

            //long numDec = Convert.ToInt64(binaryNumber, 2);
            //Console.WriteLine(numDec);   

            long decimalNumber = 0;

            for (int i = 0; i < binaryNumber.Length; i++)
            {
                if (binaryNumber[binaryNumber.Length - i - 1] == '1')
                {
                    decimalNumber += (long)Math.Pow(2, i);
                }
            }

            Console.WriteLine(decimalNumber);
        }
    }
}
