using System;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        char symbol = (char)0xA9;
        Console.WriteLine("   " + symbol + "   ");
        Console.WriteLine("  " + symbol + " " + symbol + "  ");
        Console.WriteLine(" " + symbol + "   " + symbol + " ");
        Console.WriteLine(symbol + " " + symbol + " " + symbol + " " + symbol);
    }
}

