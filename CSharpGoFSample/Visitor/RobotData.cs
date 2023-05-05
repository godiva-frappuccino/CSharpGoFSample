using CSharpGoFSample.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Visitor
{
    internal class RobotData
    {
        public Neck Neck { get; private set; }
        public Chest Chest { get; private set; }
        public RobotData(Neck neck, Chest chest)
        {
            this.Neck = neck;
            this.Chest = chest;
        }

        public void MoveNeck(RobotProcess process)
        {
            process.SetTarget(this);
            process.MoveNeck();
        }
    }

    internal class Neck
    {
        public Servo YawServo { get; private set; }
        public Servo PitchServo { get; private set; }
        public Servo RollServo { get; private set; }
    }

    internal class Chest
    {
        public Servo YawServo { get; private set; }
        public Servo PitchServo { get; private set; }
    }

    internal class Servo
    {
        public int Angle { get; set; }
}
