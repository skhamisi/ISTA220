using System;

namespace CEXR12
{
    class Program : MathFunc
    {
        static void Main(string[] args)
        {
            Initialize();

            int probType, numProb;

            void Initialize()
            {
                Console.ResetColor();
                Console.WriteLine("=====================");
                Console.WriteLine("Welcome to Math Games");
                Console.WriteLine("=====================");
                Console.WriteLine("\nChoose a test, then press [ENTER]");
                Console.WriteLine("---------------------------------\n");
                Console.WriteLine("Enter [1] for Addition\x0A" +
                    "Enter [2] for Substraction\x0A" +
                    "Enter [3] for Multiplication\x0A" +
                    "Enter [4] for Division\n");
                probType = int.Parse(Console.ReadLine());

                if (probType == 1)
                {
                    Console.WriteLine("\nHow many problems would you like to solve?");
                    numProb = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Add(numProb);
                }
                else if (probType == 2)
                {
                    Console.WriteLine("\nHow many problems would you like to solve?");
                    numProb = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Subtract(numProb);
                }
                else if (probType == 3)
                {
                    Console.WriteLine("\nHow many problems would you like to solve?");
                    numProb = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Multiply(numProb);
                }
                else if (probType == 4)
                {
                    Console.WriteLine("\nHow many problems would you like to solve?");
                    numProb = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Divide(numProb);
                }
                else
                {
                    Console.WriteLine("Invalid Choice, Press [Enter] to try again");
                    WaitForKey(ConsoleKey.Enter);
                }
                Console.Clear();
                Initialize();
            }
        }
    }

    class MathFunc
    {
        public static int Score { get; set; }
        public static Random R = new();
        public static int topNumber = 13;

        public static void Add(int numProb)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine($"You are testing division and you have {numProb} problems\x0A" +
                $"To begin your test, press [ENTER]\n");
            WaitForKey(ConsoleKey.Enter);

            double prob = numProb;
            Score = 0;

            while (numProb > 0)
            {
                int one = R.Next(topNumber);
                int two = R.Next(topNumber);
                int answer = one + two;

                Console.Write($"{one} + {two} = ");
                int userAnswer = int.Parse(Console.ReadLine());

                if (answer == userAnswer)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Correct\n");
                    Score += 1;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Incorrect");
                    Console.WriteLine($"Correct answer is {answer}\n");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                numProb--;
            }
            Console.WriteLine($"You got {Score} out of {prob} correct, your score is {(Score / prob) * 100}\n");
            Console.WriteLine("Press [ENTER] to continue");
            WaitForKey(ConsoleKey.Enter);
        }

        public static void Subtract(int numProb)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine($"You are testing division and you have {numProb} problems\x0A" +
                $"To begin your test, press [ENTER]\n");
            WaitForKey(ConsoleKey.Enter);

            double prob = numProb;
            Score = 0;

            while (numProb > 0)
            {
                int one = R.Next(topNumber);
                int two = R.Next(topNumber);
                if (two > one)
                {
                    (one, two) = (two, one);
                }
                int answer = one - two;

                Console.Write($"{one} - {two} = ");
                int userAnswer = int.Parse(Console.ReadLine());

                if (answer == userAnswer)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Correct\n");
                    Score += 1;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Incorrect");
                    Console.WriteLine($"Correct answer is {answer}\n");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                numProb--;
            }
            Console.WriteLine($"You got {Score} out of {prob} correct, your score is {(Score / prob) * 100}\n");
            Console.WriteLine("Press [ENTER] to continue");
            WaitForKey(ConsoleKey.Enter);
        }

        public static void Multiply(int numProb)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine($"You are testing division and you have {numProb} problems\x0A" +
                 $"To begin your test, press [ENTER]\n");
            WaitForKey(ConsoleKey.Enter);

            double prob = numProb;
            Score = 0;

            while (numProb > 0)
            {
                int one = R.Next(12);
                int two = R.Next(12);
                int answer = one * two;

                Console.Write($"{one} x {two} = ");
                int userAnswer = int.Parse(Console.ReadLine());

                if (answer == userAnswer)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Correct\n");
                    Score += 1;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Incorrect");
                    Console.WriteLine($"Correct answer is {answer}\n");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                numProb--;
            }
            Console.WriteLine($"You got {Score} out of {prob} correct, your score is {(Score / prob) * 100}\n");
            Console.WriteLine("Press [ENTER] to continue");
            WaitForKey(ConsoleKey.Enter);
        }

        public static void Divide(int numProb)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine($"You are testing division and you have {numProb} problems\x0A" +
                $"To begin your test, press [ENTER]\n");
            WaitForKey(ConsoleKey.Enter);

            double prob = numProb;
            Score = 0;

            while (numProb > 0)
            {
                int one = R.Next(1, topNumber);
                int two = R.Next(1, topNumber);
                //decimal answer = decimal.Round(one / two, 2);
                double answer = (double)one / (double)two;

                Console.Write($"{one} / {two} = ");
                double userAnswer = double.Parse(Console.ReadLine());
                double difference = Math.Abs(userAnswer - answer);

                //Shows you how the absolute difference is calculated for the .05 tollerence
                Console.WriteLine($"answer = {answer}, userAnswer is {userAnswer}, difference is {difference}");

                //if (answer == userAnswer)
                if(difference < .05)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Correct\n");
                    Score += 1;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Incorrect");
                    Console.WriteLine($"Correct answer is {answer}\n");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                numProb--;
            }
            Console.WriteLine($"You got {Score} out of {prob} correct, your score is {(Score / prob) * 100}\n");
            Console.WriteLine("Press [ENTER] to continue");
            WaitForKey(ConsoleKey.Enter);
        }

        public static void WaitForKey(ConsoleKey key)
        {
            while (Console.ReadKey(true).Key != key);
        }
    }
}
