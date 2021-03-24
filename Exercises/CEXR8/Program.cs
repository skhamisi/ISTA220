using System;

namespace CEXR8
{
    class Program : BisectionAlgorithm
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Computer Guesses Player's Number");
                Console.WriteLine("---------------------------------\n");
                Console.WriteLine("Choose a number from 1 to a 10.");
                BisectionFormula(0, 11);
            }

            Console.WriteLine();

            {
                Console.WriteLine("Player guesses the Computer's Number");
                Console.WriteLine("-------------------------------------\n");
                Console.WriteLine("Guess a number from 1-1000.");
                PlayerGuess guess = new PlayerGuess();
                guess.Guessing();
            }

            Console.WriteLine();

            {
                Console.WriteLine("Computer Guesses Player's Number");
                Console.WriteLine("---------------------------------\n");
                Console.WriteLine("Choose a number from 1-100 and I'll guess it.");
                ComputerGuess guess = new ComputerGuess();
                guess.GuessNumber();
            }
        }
    }
    class BisectionAlgorithm
    {
        public static void BisectionFormula(int min, int max)
        {
            int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            input:
            string input = Console.ReadLine();
            int input2;
            bool guessing = true;
            int attempts = 0;

            while (!int.TryParse(input, out input2))
            {
                if (input2 < 1 || input2 > 10)
                {
                    Console.WriteLine("Please enter a number between 1 and 10");
                    goto input;
                }
            }

            while (guessing == true)
            {
                int guess = (max + min) / 2;
                if (input2 == guess)
                {
                    Console.WriteLine($"You guessed {guess}, CONGRATS! That's right!");
                    guessing = false;
                }
                if (input2 > guess)
                {
                    Console.WriteLine($"You guessed {guess}, too low");
                    min = guess;
                }
                if (input2 < guess)
                {
                    Console.WriteLine($"You guessed {guess}, too high");
                    max = guess;
                }
                attempts++;
            }
            Console.WriteLine($"\nIt took you {attempts} tries to guess the right number");
        }
    }

    public class RandNumGen
    {
        public Random ranNum = new Random();

        public int RandomNumber(int min, int max)
        {
            return ranNum.Next(min, max);
        }
    }

    class ComputerGuess
    {
        bool guessing = true;

        public void GuessNumber()
        {
            int LoopCount = 0;
            int GuessAttempts = 0;
            int TotalGuessAttempts = 0;
            int min = 0;
            int max = 100;

            while (guessing == true)
            {
                GuessAttempts++;
                int guess = (max + min) / 2;
                string HL = Console.ReadLine();
                Console.WriteLine($"I guess {guess}. (Type [H] if its too high, [L] for to low, or [C] for correct)");

                if (HL == "C")
                {
                    Console.WriteLine($"I win! The number is {guess} It took me {GuessAttempts} attempts.");
                    Console.WriteLine("Type yes if you wish to play again or no if you want to quit");
                    string KeepPlaying = Console.ReadLine();
                    if (KeepPlaying == "yes")
                    {
                        LoopCount += 1;
                        TotalGuessAttempts += GuessAttempts;
                        GuessAttempts = 0;
                        min = 0;
                        max = 100;
                    }
                    else
                    {
                        LoopCount += 1;
                        TotalGuessAttempts += GuessAttempts;
                        Console.WriteLine($"It took {TotalGuessAttempts / LoopCount} attempts to guess the number");
                        guessing = false;
                    }
                }
                if (HL == "L")
                {
                    Console.WriteLine("Too low");
                    min = guess;
                }
                if (HL == "H")
                {
                    Console.WriteLine("Too high");
                    max = guess;
                }
            }
        }
    }

    public class PlayerGuess
    {
        public void Guessing()
        {
            RandNumGen ranNum = new RandNumGen();
            int C = ranNum.RandomNumber(1, 1000);
            int Input = -1;
            while (Input != C)
            {
                int userInput = int.Parse(Console.ReadLine());

                if (userInput == C)
                {
                    Console.WriteLine("You guessed right!");
                    break;
                }
                if (userInput > C)
                {
                    Console.WriteLine("You guessed too high");
                }
                if (userInput < C)
                {
                    Console.WriteLine("You guessed too low");
                }
            }
        }
    }
}


