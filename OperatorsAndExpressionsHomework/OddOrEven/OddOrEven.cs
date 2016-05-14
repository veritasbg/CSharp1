using System;


namespace OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine((number % 2 == 0)? "even {0}" : "odd {0}", number);
        }
    }
}