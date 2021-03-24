using System;


namespace Classes
{
    class Program
    {
        static void doWork()
        {
            Point origin = new Point();
            Point origin2 = new Point(24, 75);
            Point origin3 = new Point(527, 789, 482);
            Point origin4 = new Point(512, 641, 348);
            Point bottomRight = new Point(1366, 768);
            Point point1 = new Point(0, 0);
            Point point2 = new Point(3, 4);

            Console.WriteLine($"The distance between point1 and point2 is: " +
                $"{point1.DistanceTo(point2)}");
            Console.WriteLine($"The distance between point2 and point1 is: " +
                $"{point2.DistanceTo(point1)}");
            Console.WriteLine($"The distance between point1 and point1 is: " +
                $"{point1.DistanceTo(point1)}");
            Console.WriteLine($"The number of points created is: " +
                $"{Point.ObjectCount()}");
            Console.WriteLine($"The distance between origin 3 and origin 4 is: " +
                $"{origin3.DistanceToTriple(origin4)}");
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
