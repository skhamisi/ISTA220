using System;

namespace CEXR2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1 , Sum of 10 Grades.");
            Console.WriteLine("Enter 10 grades");
            Console.WriteLine();
            double sum = SumTenGrades(0, 1);
            Console.WriteLine();
            Console.WriteLine($"The sum of ten grades is {sum}\n\n");

            Console.WriteLine("Part 2 , Average of 10 Grades. ");
            Console.WriteLine("Enter 10 grades");
            Console.WriteLine();
            double avg = AvgTenGrades(0, 1);
            char letterGrade = Convert(avg);
            Console.WriteLine();
            Console.WriteLine($"The average of ten grades is {avg} and the letter grade is {letterGrade}\n\n");

            Console.WriteLine("Part 3, Predetermined Number of Grades");
            Console.WriteLine("How many grade(s) do you wish to enter?");
            int noScores = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter grade(s)");
            Console.WriteLine();
            double avg1 = AvgUnkGrades(0, 1, noScores);
            char letterGrade1 = Convert(avg1);
            Console.WriteLine();
            Console.WriteLine($"The average of {noScores} grade(s) is {avg1} and the letter grade is {letterGrade1}\n\n");

            Console.WriteLine("Part 4, Average of Non-predetermined Number of Scores");
            Console.WriteLine("Enter grade(s)");
            Console.WriteLine("Enter stop to evaluate average");
            Console.WriteLine();
            double avg2 = AvgAnyGrades(0, 1);
            char letterGrade2 = Convert(avg2);
            Console.WriteLine();
            Console.WriteLine($"The average of grade(s) is {avg2} and the letter grade is {letterGrade2}");
        }

        private static char Convert(double avg)
        {
            switch (avg)
            {
                case double n when n >= 90:
                    return 'A';
                case double n when n >= 80 && n < 90:
                    return 'B';
                case double n when n >= 70 && n < 80:
                    return 'C';
                case double n when n >= 60 && n < 70:
                    return 'D';
                case double n when (n < 60):
                    return 'F';
                default:
                    return ' ';
            }
        }

        private static double SumTenGrades(int sum, int count)
        {
            sum += int.Parse(Console.ReadLine());
            if (count < 10)
                return SumTenGrades(sum, count + 1);
            else
                return sum;
        }

        private static double AvgTenGrades(int sum, int count)
        {
            sum += int.Parse(Console.ReadLine());
            if (count < 10)
                return AvgTenGrades(sum, count + 1);
            else
                return sum / 10.0;
        }

        private static double AvgUnkGrades(int sum, int count, int noScores)
        {
            sum += int.Parse(Console.ReadLine());
            if (count < noScores)
                return AvgUnkGrades(sum, count + 1, noScores);
            else
                return sum / noScores;
        }

        private static double AvgAnyGrades(int sum, int count)
        {
            string input = Console.ReadLine();
            {
                if (input == "stop")
                    return sum / --count;
                else
                    sum += int.Parse(input);
                if (count > 0)
                    return AvgAnyGrades(sum, count + 1);
                else
                    return 0;
            }
        }
    }
}

