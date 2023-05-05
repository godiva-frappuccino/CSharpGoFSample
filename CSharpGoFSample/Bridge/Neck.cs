using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Bridge
{
    internal class Neck
    {
        public int Yaw { get; private set; }
        public int Pitch { get; private set; }

        public static Neck CreateInstance(bool use3DoF) 
        {
            return use3DoF ? new Neck3DoF() : new Neck();
        }
        protected Neck() { }
    }

    internal class Neck3DoF : Neck
    {
        internal Neck3DoF() { }
        public int Roll { get; private set; }
    }
}
