using System;
using System.Collections.Generic;
using System.Text;

namespace Random_Tree
{
    class TreeNode
    {
        public string value;
        public TreeNode leftChild;
        public TreeNode rightChild;
        public TreeNode()
        {
            this.value = "0";
        }
        public TreeNode(string value)
        {
            this.value = value;
        }
        public TreeNode(string value, TreeNode leftChild, TreeNode rightChild)
        {
            this.value = value;
            this.leftChild = leftChild;
            this.rightChild = rightChild;
        }
    }
}
