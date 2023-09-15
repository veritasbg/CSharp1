using System;


namespace Decoding
{
    class Decoding
    {
        static void Main()
        {
            int salt = int.Parse(Console.ReadLine());  //1 < salt < 10
            string text = Console.ReadLine();
          

            int position = 0;

            long result = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];
                if (ch == '@')
                {
                    break;
                }
                else if (ch >= 'a' && ch <= 'z' || ch >='A' && ch <= 'Z')
                {
                    result = (salt * ch) + 1000;
                }
                else if (ch >= '0' && ch <= '9')
                {
                    result = ch + salt + 500;
                }
                else
                {
                    result = ch - salt;
                }
                if (position % 2 == 0)
                {
                    Console.WriteLine("{0:F2}", result / 100.00);
                }
                else
                {
                    Console.WriteLine("{0}", result * 100);
                }
                position++;

            }
        }
    }
}