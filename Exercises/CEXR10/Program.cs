using System;

namespace CEXR10
{
    class Program : Convert
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\nPlease enter an integer to convert: ");
                string tryInput = Console.ReadLine();
                int.TryParse(tryInput, out int input);
                Console.Write("Please choose a base to convert from [2] [8] [10] [16]: \n");
                int baseNum = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"[Number: {input}] [Base: {baseNum}]");
                Console.WriteLine("------------------------");

                int result;
                string hexResult;

                if (baseNum == 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    result = BinToDec(input);
                    Console.WriteLine($"Decimal conversion is {result}");
                    result = BinToOct(input);
                    Console.WriteLine($"Octal conversion is {result}");
                    hexResult = BinToHex(input);
                    Console.WriteLine($"Hex conversion is {hexResult}");
                }
                else if (baseNum == 8)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    result = OctToBin(input);
                    Console.WriteLine($"Binary conversion is {result}");
                    result = OctToDec(input);
                    Console.WriteLine($"Decimal conversion is {result}");
                    hexResult = OctToHex(input);
                    Console.WriteLine($"Hex conversion is {hexResult}\n");
                }
                else if (baseNum == 10)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    result = DecToBin(input);
                    Console.WriteLine($"Binary conversion is {result}");
                    result = DecToOct(input);
                    Console.WriteLine($"Octal conversion is {result}");
                    hexResult = DecToHex(input);
                    Console.WriteLine($"Hex conversion is {hexResult}\n");
                }
                else if (baseNum == 16)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    result = HexToBin(tryInput);
                    Console.WriteLine($"Binary conversion is {result}");
                    result = HexToOct(tryInput);
                    Console.WriteLine($"Octal conversion is {result}");
                    result = HexToDec(tryInput);
                    Console.WriteLine($"Decimal conversion is {result}\n");
                }
                else
                {
                    Console.WriteLine("Error in base to convert from");
                }

                Console.ResetColor();
                Console.WriteLine("\nEnter [Q] to Exit || [N] to Continue");
                string exit = Console.ReadLine();

                if (exit == "Q" || exit == "q")
                {
                    Console.WriteLine("\nGoodbye!");
                    Environment.Exit(0);
                }
                else if (exit == "N" || exit == "n");
                {
                    Console.Clear();
                }
            }
        }
    }

    class Convert
    {
        static int Answer { get; set; }
        static int A;
        static int B;

        /// From Binary Conversion ///
        public static int BinToOct(int input)
        {
            int input2 = BinToDec(input);
            Answer = DecToOct(input2);
            return Answer;
        }

        public static int BinToDec(int input)
        {
            Answer = 0;
            double power = 0;

            while (input > 0)
            {
                A = input % 10;
                B = (int)(A * Math.Pow(2, power));
                Answer += B;
                power++;
                input = input / 10;
            }
            return (int)Answer;
        }

        public static string BinToHex(int input)
        {
            int input2 = BinToDec(input);
            string answer = DecToHex(input2);
            return answer;
        }

        /// From Octal Conversion ///
        public static int OctToBin(int input)
        {
            int power = 1;

            while (input > 0)
            {
                A = input % 10;
                B = DecToBin((int)A);
                Answer += B * power;
                power *= 1000;
                input = input / 10;
            }
            return Answer;
        }

        public static int OctToDec(int input)
        {
            int answer = 0;
            int power = 1;

            while (input > 0)
            {
                A = input % 10;
                input = input / 10;
                answer = (int)A * power;
                power = power * 8;
            }
            return answer;
        }

        public static string OctToHex(int input)
        {
            int input2 = OctToDec(input);
            string answer = DecToHex(input2);
            return answer;
        }

        /// From Decimal Conversion ///
        public static int DecToBin(int input)
        {
            int answer = 0;
            int power = 1;

            while (input > 0)
            {
                A = input % 2;
                input = input / 2;
                answer += (int)A * power;
                power *= 10;
            }
            return answer;
        }

        public static int DecToOct(int input)
        {
            Answer = 0;
            int power = 1;

            while (input > 0)
            {
                A = input % 8;
                input = input / 8;
                Answer += (int)A * power;
                power *= 10;
            }
            return Answer;
        }

        public static string DecToHex(int input)
        {
            char[] hexNum = new char[100];
            int i = 0;

            while (input > 0)
            {
                A = input % 16;
                if (A < 10)
                {
                    hexNum[i] = (char)(A + 48);
                    i++;
                }
                else if (A >= 10)
                {
                    hexNum[i] = (char)(A + 55);
                    i++;
                }
                input = input / 16;
            }
            Array.Reverse(hexNum);
            string strHex = new string(hexNum);
            return strHex;
        }

        /// From Hex Conversion ///
        public static int HexToBin(string input)
        {
            int input2 = HexToDec(input);
            Answer = DecToBin(input2);
            return Answer;
        }

        public static int HexToOct(string input)
        {
            int input2 = HexToDec(input);
            Answer = DecToOct(input2);
            return Answer;
        }

        public static int HexToDec(string input)
        {
            int length = input.Length;

            int power = 1;
            Answer = 0;

            for (int i = length - 1; i >= 0; i--)
            {
                if (input[i] >= '0' && input[i] <= '9')
                {
                    Answer += (input[i] - 48) * power;
                    power = power * 16;
                }
                else if (input[i] >= 'A' && input[i] <= 'F')
                {
                    Answer += (input[i] - 55) * power;
                    power = power * 16;
                }
            }
            return Answer;
        }
    }
}
