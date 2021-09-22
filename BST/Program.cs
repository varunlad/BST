using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree");
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(56);
            binaryTree.Add(30);
            binaryTree.Add(70);
            binaryTree.Add(60);
            binaryTree.Add(78);
            binaryTree.Add(80);
            binaryTree.Add(50);
            Console.ReadLine();
        }
    }
}
