using System;
using System.Collections.Generic;

namespace _94_BinaryTReeInorderTraversal
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
        public static IList<string> InorderTraversal(TreeNode tree)
        {           
            Stack<TreeNode> stk = new Stack<TreeNode>();
            List<string> list = new List<string>();

            while( tree != null || stk.Count > 0)
            {
                if (tree!=null)
                {
                    stk.Push(tree);
                    //Console.WriteLine("1. push "+tree.val);
                    tree = tree.left;
                } else {
                    tree = stk.Pop();
                    //Console.WriteLine("2. pop "+tree.val);
                    list.Add(tree.val);
                    tree = tree.right;
                }                
            }
            return list;
        }
        public static TreeNode build()
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
            var tree = build();
            var result = InorderTraversal(tree);

            foreach( var item in result)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine("\n finished");
        }
    }
}


// Inorder: left -> root -> right