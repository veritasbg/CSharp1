﻿using System;


namespace NumberComparer
{
    class NumberComparer
    {
        static void Main()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(A,B));
        }
    }
}
