using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTreeClass
    {
        // Member variables
        public NodeClass start;

        public BinarySearchTreeClass()
        {
            start = null;
        }

        public void AddNode(int data)
        {
            NodeClass node = new NodeClass(data);
            node.data = data;
            if (start==null)
            {
                start = node;
                return;
            }
            else
            {
                NodeClass currentValue = start;
                NodeClass parent;
            }

            while (true)
            {
                //temp = temp.link;
                if (currentValue <= start)
                {
                    currentValue = node.leftNode;
                }
                else
                {
                    temp = node.rightNode;
                }
            }
            // temp.link = node;
        }

        
    }
}
