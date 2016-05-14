using System;

namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {

            int a = 5;
            int b = 10;
            int c;
            Console.WriteLine("Before the exchange: {0}, {1}", a, b);
            c = a;
            a = b;
            b = c;
            Console.WriteLine("After the exchange:  {0}, {1}", a, b);

        }
    }
}
