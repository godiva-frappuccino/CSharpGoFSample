using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Visitor
{
    internal class RobotProcess
    {
        public RobotData RobotData { get; set; }
        public void SetTarget(RobotData target)
        {
            RobotData = target;
        }

        public void MoveNeck()
        {
            RobotData.Neck.YawServo.Angle = 0;
            RobotData.Neck.PitchServo.Angle = 0;
            RobotData.Neck.RollServo.Angle = 0;
        }
    }
}
