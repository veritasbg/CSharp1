﻿using System;


namespace PrintSequence1
{
    class PrintSequence1
    {
        static void Main()
        {
            for (int i = 2; i <=11; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i);
                }
            }
        }
    }
}
