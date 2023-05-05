using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Builder
{
    internal class RobotBuilder
    {
        public Robot Robot { get; private set; }
        public RobotBuilder() 
        {
            this.Robot = new Robot();
        }
        public void AddEye(Eye eye)
        {
            Robot.AddEye(eye);
        }

        public void AddArm(Arm arm)
        {
            Robot.AddArm(arm);
        }

        public Robot GetRobot()
        {
            return Robot;
        }
    }
}
