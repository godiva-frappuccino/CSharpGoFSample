using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Composite
{
    internal class Composite : Node
    {
        public string Name { get; private set; }
        Node childNode = null;

        public Composite(string name)
        {
            this.Name = name;
        }

        public void AddNode(Node childNode)
        {
            this.childNode = childNode;
        }

        public void ViewNames()
        {
            Console.WriteLine(Name);
            if(childNode != null)
            {
                childNode.ViewNames();
            }
        }
    }

    internal class Leaf : Node
    {
        public string Name { get; private set; }
        public Leaf(string name)
        {
            Name = name;
        }
        public void ViewNames()
        {
            Console.WriteLine(Name);
        }
    }
}
