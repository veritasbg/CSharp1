using System;


namespace FindingHowManyDigitsInNumber
{
    class FindingHowManyDigitsInNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int digits = 0;
            
            while (number > 0)
            {
                number /= 10;   //delim 4isloto na 10 dokato ostane polojitelno
                digits++;
            }
            Console.WriteLine(digits);
        }
    }
}
