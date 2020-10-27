using System;

namespace _104_MaxiumDepthBinaryTree
{
    class TreeNode
    {
        public string val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(string val)
        {
            this.val = val;
            this.left = this.right = null;
        }
    }
    class Program
    {
        public static TreeNode buildTree()
        {
            TreeNode tree = new TreeNode("F");
            tree.left = new TreeNode("B");
            tree.right = new TreeNode("G");
            tree.left.left = new TreeNode("A");
            tree.left.right = new TreeNode("D");
            tree.left.right.left = new TreeNode("C");
            tree.left.right.right = new TreeNode("E");
            tree.right.right = new TreeNode("I");
            tree.right.right.left = new TreeNode("H");
            return tree;
        }
        // DFS ????
        public static int MaxiumDepth(TreeNode tree)
        {
            if (tree == null)
                return 0;
            else
                return 1 + Math.Max(MaxiumDepth(tree.left), MaxiumDepth(tree.right));
        }
        static void Main(string[] args)
        {
            var tree = buildTree();
            var result = MaxiumDepth(tree);
            Console.WriteLine(result);
        }
    }
}
/*
               F
             /   \
            B     G 
           / \     \
          A   D     I
             / \   /
            C   E  H
*/