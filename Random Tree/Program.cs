using System;

namespace Random_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree testTree = createTree();
            Tree.printTree(testTree.root);
            Console.WriteLine(calculateTree(testTree.root));
        }

        public static Tree createTree()
        {
            Random rnd = new Random();
            string[] symbols = { "+", "-", "*", "/" };
            Tree toReturn = new Tree(symbols[rnd.Next(4)]);
            void addLayer(TreeNode root)
            {
                while (Tree.maxDepth(toReturn.root) < 6)
                {
                    if (root.value == "*" || root.value == "/" || root.value == "+" || root.value == "-")
                    {
                        Tree.addNodeLeft(root);
                        addLayer(root.leftChild);
                        Tree.addNodeRight(root);
                        addLayer(root.rightChild);
                    }
                    break;
                }
            }
            addLayer(toReturn.root);
            return toReturn;
        }
        public static double calculateTree(TreeNode root)
        {
            if (root != null)
            {
                switch (root.value)
                {
                    case "*":
                        return calculateTree(root.leftChild) * calculateTree(root.rightChild);
                    case "/":
                        return calculateTree(root.leftChild) / calculateTree(root.rightChild);
                    case "+":
                        return calculateTree(root.leftChild) + calculateTree(root.rightChild);
                    case "-":
                        return calculateTree(root.leftChild) - calculateTree(root.rightChild);
                    default:
                        return Int32.Parse(root.value);
                }
            }
            else
            {
                return 1;
            }
        }
    }
}
