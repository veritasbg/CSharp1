using System;


namespace BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            int bonus = int.Parse(Console.ReadLine());
            switch (bonus)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine(bonus * 10); break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine(bonus * 100); break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine(bonus * 1000); break;
                default:
                    Console.WriteLine("invalid score"); break;
            }
        }
    }
}
