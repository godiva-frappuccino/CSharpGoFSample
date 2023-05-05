using CSharpGoFSample.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Memento
{
    internal class Robot
    {
        public Servo EyeServo { get; private set; }
        public Robot(Servo eyeServo)
        {
            EyeServo= eyeServo;
        }
        
        public void MoveEye(int angle)
        {
            EyeServo.Move(angle);
        }

        public Memento CreateMemento()
        {
            return new Memento(EyeServo.Angle);
        }

        public void SetMemento(Memento memento)
        {
            EyeServo.Move(memento.Angle);
        }
    }

    internal class Servo
    {
        public int Angle { get; private set; }
        public Servo(int angle)
        {
            Angle = angle;
        }

        public void Move(int angle) 
        {
            Angle = angle;
        }
    }
}
