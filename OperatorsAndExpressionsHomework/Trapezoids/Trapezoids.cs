﻿using System;


namespace Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double surface = ((a + b)/2)*h;
            Console.WriteLine("{0:F7}",surface);
        }
    }
}
