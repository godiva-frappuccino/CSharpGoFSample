using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Mediator
{
    internal class Chest
    {
        public Servo ServoYaw { get; private set; }
        public Servo ServoPitch { get;private set; }
        public Chest(Servo servoYaw, Servo servoPitch)
        {
            ServoYaw = servoYaw;
            ServoPitch = servoPitch;
        }
        public void Move() { }

        public void AdjustPositionByNeckRotation(int yaw, int pitch, int roll)
        {
            // ロジックは省略
        }
    }

    internal class Neck
    {
        public Servo ServoYaw { get; private set; }
        public Servo ServoPitch { get; private set; }
        public Servo ServoRoll { get; private set; }

        public Neck(Servo servoYaw, Servo servoPitch, Servo servoRoll)
        {
            ServoYaw = servoYaw;
            ServoPitch = servoPitch;
            ServoRoll = servoRoll;
        }
        public void Move() { }
        public void AdjustPositionByNeckRotation(int yaw, int pitch, int roll)
        {
            // ロジックは省略
        }
    }

    internal class Servo
    {
        public int Angle { get; private set; }
    }
}
