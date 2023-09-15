using System;
using System.Globalization;

class AgeVariant1
{

    static void Main()
    {
        DateTime birthday = DateTime.ParseExact(Console.ReadLine(), "MM.dd.yyyy", CultureInfo.InvariantCulture);
        int age = (int)(DateTime.Now.Subtract(birthday).TotalDays / 365.242199);
        Console.WriteLine("{0}\n{1}", age, age + 10);
    }
}
