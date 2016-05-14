using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDoubleString
{
    class IntDoubleString
    {
        static void Main(string[] args)
        {
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "integer":
                    {
                        int number = int.Parse(Console.ReadLine());
                        Console.WriteLine(number + 1);break;
                    }
                case "real":
                    {
                        double number = double.Parse(Console.ReadLine());
                        Console.WriteLine("{0:F2}", number + 1);break;
                    }
                case "text":
                    {
                        Console.WriteLine(Console.ReadLine() + "*");break;
                    }
            }
        }
    }
}
