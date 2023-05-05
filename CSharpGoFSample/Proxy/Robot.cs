using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Proxy
{
    internal class Robot : IRobot
    {
        public Eye Eye { get; private set; }
        public Robot(Eye eye) { this.Eye = eye; }
        public void MoveEye(int x, int y)
        {
            this.Eye.x = x;
            this.Eye.y = y;
        }
    }

    internal class Eye
    {
        public int x;
        public int y;
    }
}
