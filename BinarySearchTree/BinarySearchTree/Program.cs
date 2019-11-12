using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTreeClass node = new BinarySearchTreeClass();
            node.AddNode(50);
            node.AddNode(32);
            node.AddNode(75);
            node.AddNode(12);
            node.AddNode(10);
            node.AddNode(40);
            node.AddNode(7);
            node.AddNode(84);
            node.SearchBinary(84);
            Console.ReadLine();
        }
    }
}
