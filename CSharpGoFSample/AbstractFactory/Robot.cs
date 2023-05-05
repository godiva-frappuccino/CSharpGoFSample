using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.AbstractFactory
{
    internal abstract class Robot
    {
        public abstract void PrintInfo();
    }
    internal class RobotWithEye: Robot
    {
        public long Id { get; private set; }
        public Eye Eye { get; private set; }
        public override void PrintInfo()
        {
            Console.WriteLine(Eye.ToString());
        }
        public RobotWithEye(Eye eye)
        {
            Eye = eye;
        }
    }

    internal class RobotWithArm : Robot
    {
        public long Id { get; private set; }
        public Arm Arm { get; private set; }
        public override void PrintInfo()
        {
            Console.WriteLine(Arm.ToString());
        }
        public RobotWithArm(Arm arm)
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
