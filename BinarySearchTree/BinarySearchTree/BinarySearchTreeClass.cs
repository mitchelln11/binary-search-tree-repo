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

        // Constructor
        public BinarySearchTreeClass()
        {
            start = null; // Begin starting value at null
        }

        public void AddNode(int data) // Take whatever value is given to us
        {
            NodeClass node = new NodeClass(data); // Instantiate NodeClass to use member values
            if (start==null)
            {
                start = node; // Pulls only field, which is value
                return;
            }
            else
            {
                NodeClass currentValue = start;

                while (true)
                {
                    //parent = currentValue; //Parent starts null
                    if (data <= currentValue.value)
                    {
                        if (currentValue.leftNode == null)
                        {
                            currentValue.leftNode = node;
                            return;
                        }
                        else
                        {
                            currentValue = currentValue.leftNode;
                        }
                    }
                    else if (data >= node.value)
                    {
                        
                        if (currentValue.rightNode == null)
                        {
                            currentValue.rightNode = node;
                            return;
                        }
                        else
                        {
                            currentValue = currentValue.rightNode;
                        }
                    }
                }
            }
        }

        public bool SearchBinary(int data)
        {
            NodeClass currentValue = start;
            while (true)
            {
                if (data == currentValue.value) // If it matches the parent
                {
                    start = currentValue;
                    Console.WriteLine(data + " Found!");
                    Console.ReadLine();
                    return true;
                }
                else if (data < currentValue.value)
                {
                    //Go to left
                    currentValue = currentValue.leftNode;
                }
                else if (data > currentValue.value)
                {
                    // Go to right
                    currentValue = currentValue.rightNode;
                }
                else if (data == null)
                {
                    Console.WriteLine("Number not found.");
                    Console.ReadLine();
                    return false;
                }
            }
        }

    }
}
