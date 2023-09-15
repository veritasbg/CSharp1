using System;


namespace Decoding1
{
    class Decoding1
    {
        static void Main()
        {
            int salt = int.Parse(Console.ReadLine());
            int position = 0;

            while (true)            //to do: stop the loop
            {
                int charCode = Console.Read();
                char ch = (char)charCode;
                int newCode = 0;

                if (ch == '@')
                {
                    break;
                }
                else if (char.IsLetter(ch))
                {
                    newCode = charCode * salt + 1000;
                }
                else if (char.IsDigit(ch))      //if (ch >= '0' && ch <= '9')
                {
                    newCode = charCode + salt + 500;
                }
                else
                {
                    newCode = charCode - salt;
                }
                if (position % 2 == 0)
                {
                    Console.WriteLine("{0:F2}", newCode / 100.00);
                }
                else
                {
                    Console.WriteLine("{0}", newCode * 100);
                }
                position++;
            }

        }
    }
}
