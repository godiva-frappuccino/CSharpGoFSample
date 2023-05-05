using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Bridge
{
    internal class Robot
    {
        private Neck _neck;
        public Robot(bool useNeck) 
        {
            _neck = Neck.CreateInstance(useNeck);
        }

    }
}
