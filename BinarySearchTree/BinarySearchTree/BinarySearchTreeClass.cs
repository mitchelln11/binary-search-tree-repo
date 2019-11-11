﻿using System;
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

        // Constructor
        //public BinarySearchTreeClass()
        //{
        //    start = null; // Begin starting value at null
        //}

        public void AddNode(int data) // Take whatever value is given to us
        {
            NodeClass node = new NodeClass(data); // Instantiate NodeClass to use member values
            node.value = data; // Give node value of whatever is passed through, 50 after the first pass
            if (start==null)
            {
                start = node;
                return;
            }
            else
            {
                NodeClass currentValue = start;
                NodeClass parent;

                while (true)
                {
                    //currentValue = currentValue.leftNode;
                    parent = currentValue; //Parent starts null
                    if (data <= node.value)
                    {
                        currentValue = node.leftNode;
                        if (currentValue == null)
                        {
                            parent.leftNode = node;
                            return;
                        }
                    }
                    else
                    {
                        currentValue = node.rightNode;
                        if (currentValue == null)
                        {
                            parent.rightNode = node;
                            Console.WriteLine(node);
                            return;
                        }
                    }
                }
            }
        }

        //public void SearchBinary(int data)
        //{
        //    Console.WriteLine("What number do you want to search?");
        //}
    }
}
