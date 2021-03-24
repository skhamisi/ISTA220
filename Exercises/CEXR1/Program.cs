using System;

namespace CEXR1
{
    class Program
    {
        static void Main(string[] args)
        {
            {   //Part 1 & 2 were combined into one for a cleaner look
                uint radius = 0;
                Console.WriteLine("Circumference, Area, and Volume of a Cricle.");
                Console.WriteLine("Enter an integer for the radius:");
                string input = (Console.ReadLine());
                while (!uint.TryParse(input, out radius))
                {
                    Console.WriteLine("Not a valid input");
                    Console.WriteLine("Please enter an integer for the radius");
                    input = Console.ReadLine();
                }
                Console.WriteLine();
                double circumference = (2 * Math.PI * radius);
                Console.WriteLine($"The Circumference is {circumference}");
                double area = (Math.PI * Math.Pow(radius, 2));
                Console.WriteLine($"The Area is {area}");
                double volume = (double)4 / 3 * Math.PI * Math.Pow(radius, 3) / 2;
                Console.WriteLine($"the Volume is {volume}\n\n");
            }


            {   //Part 3
                Console.WriteLine("Heron's Formula: Area of a Triangle");
                Console.WriteLine("Enter three values");
                int a = 0;
                int b = 0;
                int c = 0;
                string input1 = (Console.ReadLine());
                while (!int.TryParse(input1, out a))
                {
                    Console.WriteLine("Not a valid input");
                    Console.WriteLine("Please enter an integer");
                    input1 = Console.ReadLine();

                }
                string input2 = (Console.ReadLine());
                while (!int.TryParse(input2, out b))
                {
                    Console.WriteLine("Not a valid input");
                    Console.WriteLine("Please enter an integer");
                    input2 = Console.ReadLine();
                }

                string input3 = (Console.ReadLine());
                while (!int.TryParse(input3, out c))
                {
                    Console.WriteLine("Not a valid input");
                    Console.WriteLine("Please enter an integer");
                    input3 = Console.ReadLine();
                }
                double p = (double)(a + b + c) / 2;
                double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine();
                Console.WriteLine($"The area of a triangle is {area}\n\n");
            }

            {   //Part 4
                Console.WriteLine("Solving a Quadratic Equation");
                int a = 0;
                int b = 0;
                int c = 0;
                string input1 = (Console.ReadLine());
                while (!int.TryParse(input1, out a))
                {
                    Console.WriteLine("Not a valid input");
                    Console.WriteLine("Please enter an integer");
                    input1 = Console.ReadLine();

                }
                string input2 = (Console.ReadLine());
                while (!int.TryParse(input2, out b))
                {
                    Console.WriteLine("Not a valid input");
                    Console.WriteLine("Please enter an integer");
                    input2 = Console.ReadLine();
                }

                string input3 = (Console.ReadLine());
                while (!int.TryParse(input3, out c))
                {
                    Console.WriteLine("Not a valid input");
                    Console.WriteLine("Please enter an integer");
                    input3 = Console.ReadLine();
                }
                double x1 = ((b * -1) + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                double x2 = ((b * -1) - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                Console.WriteLine();
                Console.WriteLine($"The first solution is {x1}");
                Console.WriteLine($"The second solution is {x2}");
            }
        }
    }
}
