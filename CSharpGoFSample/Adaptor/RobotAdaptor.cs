using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Adaptor
{
    internal class RobotAdaptor
    {
        Robot robot;
        public RobotAdaptor(Robot robot)
        {
            this.robot = robot;
        }
        public void Look(int x, int y)
        {
            this.robot.MoveEye(x, y);
        }
    }
}
