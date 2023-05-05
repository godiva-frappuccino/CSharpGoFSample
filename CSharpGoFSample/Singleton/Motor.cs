using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Singleton
{
    internal class Motor
    {
        int Radians { get; private set; }
        public void SetValue(int value) { Radians = value; }
    }

    internal class LeftShoulderMotor : Motor
    {
        public LeftShoulderMotor() { }
    }

    internal class RightShoulderMotor : Motor
    {
        public RightShoulderMotor() { }
    }
}
