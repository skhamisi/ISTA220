using System;

namespace Classes
{
    class Point
    {
        private int _x = 0;
        private int _y = 0;
        private int _z = 0;
        private int serialNum;
        private static int objectCount = 0;

        public static int ObjectCount()
        {
            return objectCount;
        }

        //public Point()
        //{
        //    _x = -1;
        //    _y = -1;
        //    objectCount++;
        //    serialNum = objectCount;
        //    Console.WriteLine($"Default constructor called, point number {serialNum}");
        //}

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
            objectCount++;
            serialNum = objectCount;
            Console.WriteLine($"x:{x}, y:{y}, point number {serialNum}");
        }

        public Point(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
            objectCount++;
            serialNum = objectCount;
            Console.WriteLine($"x:{x}, y:{y}, z:{z}, point number {serialNum}");
        }

        public double DistanceTo(Point other)
        {
            int xDiff = _x - other._x;
            int yDiff = _y - other._y;
            double distance = Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2));
            return distance;
        }

        public double DistanceToTriple(Point other2)
        {
            int xDiff = _x - other2._x;
            int yDiff = _y - other2._y;
            int zDiff = _z - other2._z;
            double distance = Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2) + Math.Pow(zDiff, 2));
            return distance;
        }
    }
}
