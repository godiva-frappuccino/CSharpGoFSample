using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Command
{
    internal class Robot
    {
        Angle NeckYaw { get; set; }
        Angle NeckPitch { get; set; }
        Angle NeckRoll { get; set; }
        Angle BodyYaw { get; set; }
        Angle BodyPitch { get; set; }
        public void MoveNeckYaw(Angle angle)
        {
            Console.WriteLine(angle.ToString());
        }
        public void MoveNeckPitch(Angle angle)
        {
            Console.WriteLine(angle.ToString());
        }
        public void MoveNeckRoll(Angle angle)
        {
            Console.WriteLine(angle.ToString());
        }
        public void MoveBodyYaw(Angle angle)
        {
            Console.WriteLine(angle.ToString());
        }
        public void MoveBodyPitch(Angle angle)
        {
            Console.WriteLine(angle.ToString());
        }

    }


    internal class Angle
    {

    }
}
