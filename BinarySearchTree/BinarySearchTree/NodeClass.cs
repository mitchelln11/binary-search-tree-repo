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
        public int data;
        public NodeClass link;
        public NodeClass leftNode;
        public NodeClass rightNode;

        //Constructor
        public NodeClass(int data)
        {
            this.data=data;
        }
    }
}
