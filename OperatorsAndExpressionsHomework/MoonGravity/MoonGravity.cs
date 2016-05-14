using System;

namespace MoonGravity
{
    class MoonGravity
    {
        static void Main(string[] args)
        {
            double weightEarth = double.Parse(Console.ReadLine());
            double weightMoon = (0.17 * weightEarth);
            Console.WriteLine("{0:F3}", weightMoon);
        }
    }
}
