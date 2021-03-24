﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticProperties
{
    class Program
    {
        static void doWork()
        {
            Polygon square = new Polygon();
            Console.WriteLine($"Square: number of sides is {square.NumSides}, length of each side is {square.SideLength}");

            Polygon triangle = new Polygon { NumSides = 3 };
            Console.WriteLine($"Triangle: number of sides is {triangle.NumSides}, length of each side is {triangle.SideLength}");

            Polygon pentagon = new Polygon { SideLength = 15.5, NumSides = 5 };
            Console.WriteLine($"Pentagon: number of sides is {pentagon.NumSides}, length of each side is {pentagon.SideLength}");

            Polygon octagon = new Polygon { SideLength = 5, NumSides = 8 };
            Console.WriteLine($"Octagon: number of sides is {octagon.NumSides}, length of each side is {octagon.SideLength}");
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
