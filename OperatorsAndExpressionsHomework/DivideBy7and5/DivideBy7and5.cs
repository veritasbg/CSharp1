using System;


namespace DivideBy7and5
{
    class DivideBy7and5
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            bool divided = ((number % 7 == 0) && (number % 5 == 0)); 

            Console.WriteLine(divided ? "true {0}" : "false {0}", number);
        }
    }
}
