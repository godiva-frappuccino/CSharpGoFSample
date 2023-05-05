using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Composite
{
    internal class Main
    {
        public void Run()
        {
            Composite root = new Composite("root");
            Composite branch1 = new Composite("b1");
            Composite branch2 = new Composite("b2");
            Leaf leaf = new Leaf("leaf");
            root.AddNode(branch1);
            branch1.AddNode(branch2);
            branch2.AddNode(leaf);
            root.ViewNames();
        }



    }
}
