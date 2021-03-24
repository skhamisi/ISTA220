using System;

namespace CEXR10
{
    class Program : Convert
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer to convert: ");
            int input = int.Parse(Console.ReadLine());
            Console.Write("Please choose a base to convert from [2] [8] [10] [16]: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"[Number: {input}] [Base: {baseNum}]");
            Console.WriteLine("----------------------");

            int result;
            string hexResult;

            if (baseNum == 2)
            {
                result = BinToDec(input);
                Console.WriteLine($"Decimal conversion is {result}");
                result = BinToOct(input);
                Console.WriteLine($"Octal conversion is {result}");
                result = BinToHex(input);
                Console.WriteLine($"Hex conversion is {result}");
            }
            else if (baseNum == 8)
            {
                result = OctToBin(input);
                Console.WriteLine($"Binary conversion is {result}");
                result = OctToDec(input);
                Console.WriteLine($"Decimal conversion is {result}");
                hexResult = OctToHex(input);
                Console.WriteLine($"Hex conversion is {hexResult}");
            }
            else if (baseNum == 10)
            {
                result = DecToBin(input);
                Console.WriteLine($"Binary conversion is {result}");
                result = DecToOct(input);
                Console.WriteLine($"Octal conversion is {result}");
                hexResult = DecToHex(input);
                Console.WriteLine($"Hex conversion is {hexResult}");
            }
            else if (baseNum == 16)
            {
                result = HexToBin(input);
                Console.WriteLine($"Binary conversion is {result}");
                result = HexToOct(input);
                Console.WriteLine($"Octal conversion is {result}");
                result = HexToDec(input);
                Console.WriteLine($"Decimal conversion is {result}");
            }
            else
            {
                Console.WriteLine("Error in base to convert from");
            }
        }
    }

    class Convert
    {
        static int Answer { get; set; }
        static int A;
        static int B;
        static int C;
        static int D;
        static int E;

        /// From Binary Conversion ///
        public static int BinToOct(int input)
        {
            int factor = 1;

            while (input > 0)
            {
                A = input % 1000;
                B = A % 10;
                C = ((A / 10) % 10) * 2;
                D = (A / 100) * 4;
                E = B + C + D;
                Answer += E * factor;
                factor *= 10;
                input = input / 1000;
            }
            return Answer;
        }

        public static int BinToDec(int input)
        {
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

        public static int BinToHex(int input)
        {
            int answer = 0;

            while (input > 0)
            {
     
            }
            return (int)answer;
        }

        /// From Octal Conversion ///
        public static int OctToBin(int input)
        {
            int factor = 1;
            int Answer1 = 0;
            int b1 = 0;
            int a2 = 0;

            while (input > 0)
            {
                a2 = input % 10;
                b1 = DecToBin((int)a2);
                Answer1 += b1 * factor;
                factor *= 1000;
                input = input / 10;
            }
            return (int)Answer1;
        }

        public static int OctToDec(int input)
        {
            int answer = 0;
            int factor = 1;

            while (input > 0)
            {
                A = input % 10;
                input = input / 10;
                answer = (int)A * factor;
                factor = factor * 8;
            }
            return answer;
        }

        public static string OctToHex(int input)
        {
            char[] hexNum = new char[100];
            int i = 0;

            int input2 = OctToDec(input);

            while (input2 > 0)
            {
                A = input2 % 16;
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
                input2 = input2 / 16;
            }
            Array.Reverse(hexNum);
            string strHex = new string(hexNum);
            return strHex;
        }

        /// From Decimal Conversion ///
        public static int DecToBin(int input)
        {
            int answer = 0;
            int factor = 1;

            while (input > 0)
            {
                A = input % 2;
                input = input / 2;
                answer += (int)A * factor;
                factor *= 10;
            }
            return answer;
        }

        public static int DecToOct(int input)
        {
            int answer = 0;
            int factor = 1;

            while (input > 0)
            {
                A = input % 8;
                input = input / 8;
                answer += (int)A * factor;
                factor *= 10;
            }
            return answer;
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
                else if(A >= 10)
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

        public static int HexToBin(int input)
        {
            int answer = 0;
            while (input > 0)
            {

            }
            return (int)answer;
        }


        public static int HexToOct(int input)
        {
            int answer = 0;
            while (input > 0)
            {

            }
            return (int)answer;
        }


        public static int HexToDec(int input)
        {
            int answer = 0;

            while (input > 0)
            {

            }
            return (int)answer;
        }
    }
}
