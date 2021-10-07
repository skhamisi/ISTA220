using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEXR11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the Vector Distance exercise\n");

            List<VectorPoint> pointsList = new();
            List<VectorPoint> pointsList2 = new();

            for (int i = 0; i < 100; i++)
            {
                pointsList.Add(VectorPoint.RandomVector(i, i + 25));
            }

            VectorPoint[] a = new VectorPoint[2];
            a = VectorPoint.ShortestDist(pointsList);

            Console.WriteLine("The two points that have the shortest distance between them are:");

            foreach (VectorPoint v in a)
            {
                Console.WriteLine($"({v.x},{v.y})");
            }

            Console.WriteLine();

            for (int i = 0; i < 100; i++)
            {
                pointsList2.Add(VectorPoint.RandomVector(i, i + 25));
            }

            VectorPoint[] b = new VectorPoint[2];
            b = VectorPoint.ShortestDist(pointsList2);

            Console.WriteLine("The two points that have the shortest distance between them are:");

            foreach (VectorPoint v in b)
            {
                Console.WriteLine($"({v.x},{v.y},{v.z})");
            }
        }
    }

    public class VectorPoint
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        public static double Distance(VectorPoint A, VectorPoint B)
        {
            return Math.Sqrt((Math.Pow(B.x - A.x, 2) + (Math.Pow(B.y - A.y, 2)) + (Math.Pow(B.z - A.z, 2))));
        }

        public static VectorPoint RandomVector(int twoD)
        {
            VectorPoint vector = new();
            Random rnd = new();
            int x = rnd.Next(100) + twoD;
            int y = rnd.Next(100) - twoD;
            vector.x = x;
            vector.y = y;
            return vector;
        }

        public static VectorPoint RandomVector(int twoD, int threeD)
        {
            VectorPoint vector = new();
            Random rand = new();
            int x = rand.Next(100) + twoD;
            int y = rand.Next(100) - twoD;
            int z = rand.Next(100) + threeD;
            vector.x = x;
            vector.y = y;
            vector.z = z;
            return vector;
        }

        public static VectorPoint[] ShortestDist(List<VectorPoint> vectorList)
        {
            double lowest = Distance(vectorList[0], vectorList[1]);

            VectorPoint[] result = new VectorPoint[2];

            for (int i = 0; i < vectorList.Count; i++)
            {
                for (int j = i + 1; j < vectorList.Count; j++)
                {
                    double dist = Distance(vectorList[i], vectorList[j]);
                    if (dist < lowest)
                    {
                        lowest = dist;
                        result[0] = vectorList[i];
                        result[1] = vectorList[j];
                    }
                }
            }
            return result;
        }
    }
}
