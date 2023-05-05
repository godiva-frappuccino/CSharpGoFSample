using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Builder
{
    internal class Robot
    {
        public Eye Eye { get; private set; }
        public Arm Arm { get; private set; }

        public Robot() { }
        public void AddEye(Eye eye)
        {
            this.Eye = eye;
        }
        public void AddArm(Arm arm)
        {
            this.Arm = arm;
        }
    }

    internal class Arm
    {
    }

    internal class Eye
    {
    }
}
