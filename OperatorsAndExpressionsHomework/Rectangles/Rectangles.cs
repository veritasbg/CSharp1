using System;

namespace Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            double widht = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double surface = widht * height;
            double perimeter = 2 * (widht + height);
            Console.WriteLine("{0:F2} {1:F2}", surface,perimeter);
        }
    }
}
