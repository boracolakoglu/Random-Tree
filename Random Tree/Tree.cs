using System;
using System.Collections.Generic;
using System.Text;

namespace Random_Tree
{
    class Tree
    {
        public TreeNode root;
        public Tree()
        {

        }
        public Tree(string value)
        {
            this.root = new TreeNode(value);
        }
        public static void addNodeLeft(TreeNode parent)
        {
            string[] symbols = { "+", "-", "*", "/" };
            Random rnd = new Random();
            string newString;
            if (rnd.NextDouble() < 0.5)
            {
                newString = rnd.Next(11).ToString();
            }
            else
            {
                newString = symbols[rnd.Next(4)];
            }
            TreeNode node = new TreeNode(newString);
            parent.leftChild = node;
        }//addnode methods probably should be in the program.cs since the other method uses them in program.cs
        public static void addNodeRight(TreeNode parent)
        {
            string[] symbols = { "+", "-", "*", "/" };
            Random rnd = new Random();
            string newString;
            if (rnd.NextDouble() < 0.5)
            {
                newString = rnd.Next(11).ToString();
            }
            else
            {
                newString = symbols[rnd.Next(4)];
            }
            TreeNode node = new TreeNode(newString);
            parent.rightChild = node;
        }
        public static void printTree(TreeNode mainRoot)
        {
            if (mainRoot.leftChild != null)
            {
                printTree(mainRoot.leftChild);
            }
            Console.Write(mainRoot.value + " ");
            if (mainRoot.rightChild != null)
            {
                printTree(mainRoot.rightChild);
            }
        }
        public static int maxDepth(TreeNode node)
        {
            if (node == null)
                return 0;
            else
            {
                int lDepth = maxDepth(node.leftChild);
                int rDepth = maxDepth(node.rightChild);

                if (lDepth > rDepth)
                    return (lDepth + 1);
                else
                    return (rDepth + 1);
            }
        }

    }
}
