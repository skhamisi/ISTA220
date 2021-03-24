using System;

namespace CEXR3
{
    class Program
    {
        public static void Main(string[] args)
        {
            MathCalc();
            HeronsFormula();
            QuadraticCalculator();
        }

        public static void MathCalc()
        {
            // Parts 1 and 2 //
            Console.WriteLine("Circumference, Area, and Volume of a Cricle");
            Console.WriteLine("Enter a number for the radius");
            string input;
            int radius;

            do
            {
               input = Console.ReadLine();
            }
            while (!IsImaginaryNumber(input));

            radius = int.Parse(input);
            double circumference = (2 * Math.PI * radius);
            Console.WriteLine();
            Console.WriteLine($"The Circumference is {circumference}");
            double area = (Math.PI * Math.Pow(radius, 2));
            Console.WriteLine($"The Area is {area}");
            double volume = (double)4 / 3 * Math.PI * Math.Pow(radius, 3) / 2;
            Console.WriteLine($"the Volume is {volume}\n\n");
        }

        public static void HeronsFormula()
        {
            // Part 3 //
            Console.WriteLine("Heron's Formula: Area of a Triangle.");
            int a = 0;
            int b = 0;
            int c = 0;
            string input1 = "";
            string input2 = "";
            string input3 = "";

            do
            {
                Console.WriteLine("Enter side (a)");
                input1 = Console.ReadLine();
            }
            while (!IsImaginaryNumber(input1));
            a = int.Parse(input1);
            Console.WriteLine();

            do
            {
                Console.WriteLine("Enter side (b)");
                input2 = Console.ReadLine();
            }
            while (!IsImaginaryNumber(input2));
            b = int.Parse(input2);
            Console.WriteLine();

            do
            {
                Console.WriteLine("Enter side (c)");
                input3 = Console.ReadLine();
            }
            while (!IsImaginaryNumber(input3));
            c = int.Parse(input3);

            double p = (double)(a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine();
            Console.WriteLine($"The area of a triangle is {area}\n\n");
        }

        // Part 4 //
        public static void QuadraticCalculator()
        {
            Console.WriteLine("Solving a Quadratic Equation");
            int a = 0;
            int b = 0;
            int c = 0;
            string input1;
            string input2;
            string input3;

            do
            {
                Console.WriteLine("Enter (a) value");
                input1 = Console.ReadLine();

            } while (!IsImaginaryNumber(input1, true));
            a = int.Parse(input1);
            Console.WriteLine();

            do
            {
                Console.WriteLine("Enter (b) value");
                input2 = Console.ReadLine();

            } while (!IsImaginaryNumber(input2, true));
            b = int.Parse(input2);
            Console.WriteLine();

            do
            {
                Console.WriteLine("Enter (c) value");
                input3 = Console.ReadLine();

            } while (!IsImaginaryNumber(input3, true));
            c = int.Parse(input3);
            Console.WriteLine();

            double x1 = ((b * -1) + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            double x2 = ((b * -1) - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            Console.WriteLine();
            Console.WriteLine($"The first solution is {x1}");
            Console.WriteLine($"The second solution is {x2}");
        }

        public static bool IsImaginaryNumber(string input, bool QuadraticEquation = false)
        {
            if (QuadraticEquation)
            {
                try
                {
                    int Rn = int.Parse(input);
                    if (Rn == 0)
                    {
                        Console.WriteLine("Number cannot be zero");
                        return false;
                    }
                    return true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Number cannot be a character");
                    return false;
                }
                finally
                {
                    Console.WriteLine("Righteous Dude!");
                }
            }
            else
            {
                try
                {
                    int Rn = int.Parse(input);
                    if (Rn <= 0)
                    {
                        Console.WriteLine("Number cannot be zero or negative");
                        return false;
                    }
                    return true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Number cannot be a character");
                    return false;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Number cannot be zero");
                    return false;
                }
                finally
                {
                    Console.WriteLine("Righteous Dude!");
                }
            }
        }
    }
}
