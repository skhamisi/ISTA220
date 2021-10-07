using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CEXR13
{
    class Program : TestFunc
    {
        static void Main(string[] args)
        {
            Initialize();

            void Initialize()
            {
                Console.WriteLine("HISTORY TEST");
                Console.WriteLine("============\n");
                List<string> one = new();
                List<string[]> two = new();
                MakeTest();
                Console.Clear();
                Initialize();
            }
        }
    }

    class TestFunc
    {
        public static int Score { get; set; }

        public static void MakeTest()
        {
            List<string> testBank = File.ReadAllLines(@"C:\Users\Samer\MSSA2021\presidents.csv").ToList();
            List<string> testQuestions = new();
            List<string> testChoices = new();

            for (int i = 0; i <= testBank.Count - 1; i++)
            {
                string line = testBank[i];
                string[] split = line.Split(',');
                string question = split[0];
                string answer = split[1];
                string wrong1 = split[2];
                string wrong2 = split[3];
                string wrong3 = split[4];
                testQuestions.Add(question);
                testChoices.Add(answer);
                testChoices.Add(wrong1);
                testChoices.Add(wrong2);
                testChoices.Add(wrong3);
            }

            GiveTest(testQuestions, testChoices);
        }

        public static void GiveTest(List<string> Questions, List<string> testChoices)
        {
            Console.Write("How Many Questions Would You Like to Answer? " +
              $"Enter from 1 to {Questions.Count}: ");
            int numProb = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nTest created, you have {numProb} questions\x0a" +
                "Press [Enter to Start]\n");
            WaitForKey(ConsoleKey.Enter);

            Random r = new();
            string answer = testChoices[0].ToString();

            for (int i = 0; i < numProb; i++)
            {
                Console.WriteLine($"{i + 1}. {Questions[i]}");

                for (int j = 1; j <= 4; j++)
                {
                    //int index = r.Next(testChoices.Count);
                    Console.WriteLine($"\t{j}. {testChoices[j]}");
                }

                Console.Write("Enter your answer: ");
                string choice = Console.ReadLine();

                if (choice == answer)
                {
                    Console.WriteLine("Correct!\n");
                    Score++;
                }
                else
                {
                    Console.WriteLine("Incorrect\x0A" +
                        $"Correct answer is: {answer}\n");
                }
            }
            Console.WriteLine($"You got {Score} out of {numProb} correct, your score is {(Score / numProb) * 100}\n");
            Console.WriteLine("To Continue, press [ENTER]");
            WaitForKey(ConsoleKey.Enter);
        }

        public static void WaitForKey(ConsoleKey key)
        {
            while (Console.ReadKey(true).Key != key) ;
        }
    }
}


//1. Create Test with questions
//2. Create Answer bank
