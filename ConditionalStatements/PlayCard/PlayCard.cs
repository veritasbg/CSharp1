﻿using System;

namespace PlayCard
{
    class PlayCard
    {
        static void Main()
        {
            string sign = Console.ReadLine();

            if (sign == "2" || sign == "3" || sign == "4" || sign == "5" || sign == "6" || sign == "7" || sign == "8" || sign == "9"
                || sign == "10" || sign == "J" || sign == "Q" || sign == "K" || sign == "A")
            {
                Console.WriteLine("yes {0}", sign);
            }
            else
            {
                Console.WriteLine("no {0}", sign);
            }
        }
    }
}
