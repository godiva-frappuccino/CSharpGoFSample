using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Iterator
{
    internal interface IAggrigate<T>
    {
        IIterator<T> Iterator();
    }
}
