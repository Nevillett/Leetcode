using System;
using System.Collections.Generic;

namespace _144._2_BinaryTreePreorderTraversal
{
    class Program
    {
        public class TreeNode
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
        public static IList<string> PreorderTraversal(TreeNode root)
        {
            Stack<TreeNode> stk = new Stack<TreeNode>();
            List<string> lt = new List<string>();

            stk.Push(root);
            while(stk.Count > 0)
            {
                var current = stk.Pop();
                lt.Add(current.val);

                if (current.right != null)
                    stk.Push(current.right);
                if (current.left != null)
                    stk.Push(current.left);                                    
            }
            return lt;
        }
        public static TreeNode buikdTree()
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

        static void Main(string[] args)
        {
            var tree = buikdTree();
            //var result = PreorderTraversal(tree);
            // Recursive way:
            var lst = new List<string>();
            var result = Solution2.Preorder_Traversal(tree, lst);

            foreach( var item in result)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine("\n finished!");
        }
    }
}
