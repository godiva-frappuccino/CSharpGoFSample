using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CSharpGoFSample.Flyweight
{
    internal class Pool
    {
        Dictionary<long, Angle> pool = new Dictionary<long, Angle>();

        void PutAngle(Angle angle)
        {
            if (pool.ContainsKey(angle.ServoId))
            {
                pool[angle.ServoId] = angle;
            }
            else
            {
                pool.Add(angle.ServoId, angle);
            }
        }

        Angle GetAngle(long servoId)
        {
            return pool[servoId];
        }
    }
}
