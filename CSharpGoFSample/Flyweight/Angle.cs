using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Flyweight
{
    internal class Angle
    {
        public long ServoId { get; private set; }
        public double Value { get; private set; }
        private Angle(double value) { Value = value; }

        public Angle Of(double value)
        {
            CheckValue(value);
            return new Angle(value);
        }

        public void SetAngle(double value)
        {
            CheckValue(value);
            Value = value;
        }

        public void CheckValue(double value)
        {
            if (value < 0 || value > 180) throw new Exception();

        }
    }
}
