using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Command
{
    internal class MoveCommand
    {
        private Robot _robot;
        public MoveCommand(Robot robot) { _robot = robot; }
        public void Move3DoF()
        {
            _robot.MoveNeckYaw(new Angle());
            _robot.MoveNeckPitch(new Angle());
            _robot.MoveNeckRoll(new Angle());
        }
        public void Move5DoF()
        {
            _robot.MoveNeckYaw(new Angle());
            _robot.MoveNeckPitch(new Angle());
            _robot.MoveNeckRoll(new Angle());
            _robot.MoveBodyYaw(new Angle());
            _robot.MoveBodyPitch(new Angle());
        }
    }
}
