using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Decorator
{
    internal class RobotDecorator
    {
        public Robot Robot { get; private set; }
        public RobotDecorator(Robot robot)
        {
            this.Robot = robot;
        }
        public void LookWithLogging(int x, int y)
        {
            Console.WriteLine($"Look {x}, {y}");
            this.Robot.MoveEye(x, y);
        }
    }
}
