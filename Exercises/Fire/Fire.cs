﻿using System;
/*
...##...
..#..#..
.#....#.
#......#
#......#
.#....#.
--------
\\\\////
.\\\///.
..\\//..
...\/...
*/  
namespace Fire
{
    class Fire
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("-");   //--------
            }
            Console.WriteLine();
        }
    }
}
