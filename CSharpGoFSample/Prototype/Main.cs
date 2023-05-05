using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Prototype
{
    internal class Main
    {
        public void Run()
        {
            Human human = new Human();
            Robot robot = new Robot();

            human.ApplySensorvalue();
            robot.Neck.Servo = (Servo)human.Neck.Servo.Clone();
        }
    }
    internal class Robot
    {
        public Neck Neck { get; private set; }
    }

    internal class Human
    {
        public Neck Neck { get; private set; }
        public Human() { }
        public void ApplySensorvalue()
        {

        }
    }

    internal class Neck
    {
        public Servo Servo { get; set; }
    }

}
