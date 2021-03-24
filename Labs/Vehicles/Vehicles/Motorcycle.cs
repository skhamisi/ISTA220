using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Motorcycle : Vehicle
    {
        internal void Accelerate()
        {
            Console.WriteLine("Motorcycle is going fast");
        }

        internal void Brake()
        {
            Console.WriteLine("Motorcycle skidding tires on pavement");
        }

        public override void Drive()
        {
            Console.WriteLine("Motorcycling");
        }
    }
}
