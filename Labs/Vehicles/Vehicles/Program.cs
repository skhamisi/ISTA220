using System;

namespace Vehicles
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("Testing Vehicle");
            Vehicle w = new Vehicle();
            w.StartEngine("Vroom Vroom");
            w.Drive();
            w.StopEngine("Phut Phut\n");

            Console.WriteLine("----------------------\n");
            Console.WriteLine("Journey by airplane:");
            Airplane myPlane = new Airplane();
            myPlane.StartEngine("Contact");
            myPlane.TakeOff();
            myPlane.Drive();
            myPlane.Land();
            myPlane.StopEngine("Whirr\n");

            Console.WriteLine("----------------------\n");
            Console.WriteLine("Journey by car:");
            Car myCar = new Car();
            myCar.StartEngine("Brm brm");
            myCar.Accelerate();
            myCar.Drive();
            myCar.Brake();
            myCar.StopEngine("Phut phut\n");

            Console.WriteLine("----------------------\n");
            Console.WriteLine("Journey by Motorcycle");
            Motorcycle shadow = new Motorcycle();
            shadow.StartEngine("IT'S GOOOOTTTAAA BE A HONDAAAAAAAA");
            shadow.Accelerate();
            shadow.Drive();
            shadow.Brake();
            shadow.StopEngine("Clunk");

            Console.WriteLine("----------------------\n");
            Console.WriteLine("Testing polymorphism");
            Vehicle v = myCar;
            v.Drive();
            v = myPlane;
            v.Drive();
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
