using System;

namespace Cube
{
    class Cube
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int fieldsize = n * 2 - 1;
            int mid = n - 1;

            char empty = ' ';
            char top = '/';
            char side = 'X';
            char edge = ':';

            for (int row = 0; row < fieldsize; row++)
            {
                for (int col = 0; col < fieldsize; col++)
                {
                    if (col == 0 && row >= mid || 
                        col == mid && row >= mid ||
                        col == fieldsize - 1 && row<= mid ||
                        col >= mid && row == 0 ||
                        col <= mid && row == mid ||
                        col <= mid && row == fieldsize-1 ||
                        col+row == mid ||
                        col+ row == fieldsize-1+mid ||
                        col+row == fieldsize-1 && row <= mid)
                    {
                        Console.Write(edge);
                    }
                    else if (col > mid &&
                        col + row <= fieldsize - 1 + mid &&
                         col + row >= fieldsize-1)
                    {
                        Console.Write(side);
                    }
                    else if (row < mid &&
                            col + row >= mid)
                    {
                        Console.Write(top);
                    }
                    else
                    {
                        Console.Write(empty);
                    }
                    
                }

                Console.WriteLine();
            }
        }
    }
}
