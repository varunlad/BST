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
            BinarySearchTree<int> binaryTree = new BinarySearchTree<int>(56);
            binaryTree.Insert(30);
            binaryTree.Insert(70);
            binaryTree.Insert(22);
            binaryTree.Insert(40);
            binaryTree.Insert(60);
            binaryTree.Insert(95);
            binaryTree.Insert(95);
            binaryTree.Insert(63);
            binaryTree.Display();
            binaryTree.GetSize();
            bool result =binaryTree.IfExists(63,binaryTree);
            Console.ReadLine();
        }
    }
}
