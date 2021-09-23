using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    
    class BinarySearchTree<T> where T: IComparable<T> 
    {
        public T NodeData { get; set; }
        public BinarySearchTree<T> LeftTree { get; set; }
        public BinarySearchTree<T> RightTree { get; set; }
        public static int leftcCount;
        public static int righyCount;
        /// <summary>
        /// Assigning the initiation
        /// </summary>
        /// <param name="nodeData"></param>
        public BinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }
        int leftCount = 0, rightCount = 0;
        bool result = false;
        public void Insert(T item) //Insert into the Tree
        {
            T currentNodeValue = this.NodeData;
            if((currentNodeValue.CompareTo(item)>0))
            {
                if (this.LeftTree == null)
                    this.LeftTree = new BinarySearchTree<T>(item);
                else
                    this.LeftTree.Insert(item); //Insert onto the Left side of Tree
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new BinarySearchTree<T>(item);
                else
                    this.RightTree.Insert(item); //Insert into Right side of Tree
            }
        }
        public void Display() //Display of Binary Search Tree.
        {
            
            if (this.LeftTree!=null)
            {
                leftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                rightCount++;
                this.RightTree.Display();
            }
        }

    }
}
