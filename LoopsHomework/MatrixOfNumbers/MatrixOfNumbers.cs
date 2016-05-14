using System;


namespace MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int num = row; num <= (row + n - 1); num++)    // num <= (row + n - 1)
                {
                    Console.Write("{0} ", num);
                }
                Console.WriteLine();
            }
        }
    }
}
