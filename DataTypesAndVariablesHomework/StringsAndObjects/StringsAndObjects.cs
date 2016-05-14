using System;



class StringsAndObjects
{
    static void Main()
    {
        string a = "Hello";
        string b = "World";
        object concat = (a + " " + b);
        string c = (string)concat;
        Console.WriteLine("The first string is: {0}\nThe second string is: {1}\nThe concatenation is: {2} \nThe third string is: {3}", a, b, concat, c);

    }
}

