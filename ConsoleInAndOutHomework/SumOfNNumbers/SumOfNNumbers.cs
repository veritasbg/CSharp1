using System;


namespace SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double sum = 0;
            double numberI;
            for (int i = 0; i < N; i++)
            {
                numberI = double.Parse(Console.ReadLine());
                sum += numberI;
            }
            Console.WriteLine(sum);
        }
    }
}
