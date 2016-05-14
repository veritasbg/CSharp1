using System;


namespace Calculate
{
    class Calculate
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double sum = 1;
            int factorial = 1; // factorial must be int

          
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;

                sum += factorial / Math.Pow(x, i);
            }

                Console.WriteLine("{0:F5}", sum); 

        }
    }
}
