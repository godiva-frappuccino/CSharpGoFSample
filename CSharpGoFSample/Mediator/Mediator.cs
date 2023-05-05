using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Mediator
{
    internal class Mediator
    {
        public Neck Neck { get; private set; }
        public Chest Chest { get; private set; }
        public Mediator(Neck neck, Chest chest)
        {
            Neck = neck;
            Chest = chest;
        }

        public void Move()
        {
            Neck.Move();
            Chest.AdjustPositionByNeckRotation(
                Neck.ServoYaw.Angle,
                Neck.ServoPitch.Angle,
                Neck.ServoRoll.Angle);
        }
    }
}
