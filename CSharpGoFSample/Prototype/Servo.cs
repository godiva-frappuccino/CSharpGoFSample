using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CSharpGoFSample.Prototype
{
    internal class Servo : ICloneable
    {
        public int Angle { get; set; }

        public Servo(int angle)
        {
            Angle = angle;
        }

        protected Servo(Servo other)
        {
            this.Angle = other.Angle;
        }

        public virtual object Clone()
        {
            return new Servo(this);
        }
    }


}
