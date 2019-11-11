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
            BinarySearchTreeClass binarySearch = new BinarySearchTreeClass();
            binarySearch.AddNode(50);
            binarySearch.AddNode(32);
            binarySearch.AddNode(75);
            binarySearch.AddNode(12);
            binarySearch.AddNode(10);
            binarySearch.AddNode(40);
            binarySearch.AddNode(7);
            binarySearch.AddNode(84);
            Console.ReadLine();
        }
    }
}
