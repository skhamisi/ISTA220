﻿using System;

namespace Extensions
{
    class Program
    {
        static void doWork()
        {
            bool continued = true;

            while(continued)
            {
                Console.Write("Enter a number: ");
                string inputString = Console.ReadLine();
                int x = int.Parse(inputString);

                if(x < 1)
                {
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                }

                for (int i = 2; i <= 10; i++)
                {
                    Console.WriteLine($"{x} in base {i} is {x.ConvertToBase(i)}\n");
                }
            }
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
