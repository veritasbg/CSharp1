using System;


namespace PersianRugs
{
    class PersianRugs
    {
        static void Main()
        {

            int N = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int widht = 2 * N + 1;

            for (int row = 0; row < N; row++)
            {
                Console.Write(new string('#', row));
                Console.Write('\\');
                

                int spaceLeft = widht - row - row - 1 - 1 - D - D;
                if (spaceLeft >=2)
                {
                    Console.Write(new string(' ', D));

                    Console.Write('\\');
                    Console.Write(new string('.',spaceLeft-2));
                    Console.Write('/');
                    Console.Write(new string(' ', D));


                }
                else
                {
                    Console.WriteLine(new string(' ', widht-row-row-2));
                }
                
                

                Console.Write('/');
                Console.Write(new string('#', row));


                Console.WriteLine();
            }
            Console.WriteLine(new string('#', N) + 'X' + new string('#', N));

            for (int row = N - 1; row >= 0; row--)
            {
                Console.Write(new string('#', row));
                Console.Write('/');
                Console.Write(new string(' ', widht - row - row - 1 - 1));
                Console.Write('\\');
                Console.Write(new string('#', row));

                

                Console.WriteLine();

            }
            
        }
    }
}