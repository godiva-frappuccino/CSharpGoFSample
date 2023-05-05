using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Proxy
{
    internal class RobotProxy : IRobot
    {
        public Robot Robot { get; private set; }
        public RobotProxy(Robot robot)
        {
            this.Robot = robot;
        }
        public void MoveEye(int x, int y)
        {
            Console.WriteLine($"Try Looking {x}, {y}");
            this.Robot.MoveEye(x, y);
            Console.WriteLine($"Looking Completed");
        }
    }
}
