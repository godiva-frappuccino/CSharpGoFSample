using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Facade
{
    internal class Motor
    {
        public double Angle { get; set; }
        public Motor(double angle)
        {
            Angle = angle;
        }

        public void MockWrite(double angle)
        {
            Angle = angle;
            Console.WriteLine(Angle);
        }
    }

    internal class Sensor
    {
        public double ReadValue()
        {
            return Random.Shared.NextDouble() * 180;
        }
    }
}
