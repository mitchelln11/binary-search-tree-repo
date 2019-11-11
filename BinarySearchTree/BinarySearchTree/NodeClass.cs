using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class NodeClass
    {
        // Member variables
        public int value;
        public NodeClass leftNode;
        public NodeClass rightNode;

        //Constructor
        public NodeClass(int data)
        {
            this.value = data; // For every time through, update value to whatever is being passed through
        }
    }
}
