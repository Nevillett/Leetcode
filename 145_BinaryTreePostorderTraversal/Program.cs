using System;
using System.Collections.Generic;

namespace _145_BinaryTreePostorderTraversal
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
        public static List<string> PostorderTraversal(TreeNode tree)
        {
            var stk = new Stack<TreeNode>();
            var lt = new List<string>();

            stk.Push(tree);
            while (stk.Count > 0)
            {
                var curr = stk.Pop();
                lt.Insert(0, curr.val); // Reverse the order adding to the list

                if (curr.left != null)
                    stk.Push(curr.left);
                if (curr.right != null)
                    stk.Push(curr.right);
            }
            return lt;
        }
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
        //Recursive:
        public static List<string> Postorder_Traversal(TreeNode tree, List<string> lt)
        {
            if (tree == null)
                return lt;            
            if (tree.left != null)
                Postorder_Traversal(tree.left, lt);
            if (tree.right != null)
                Postorder_Traversal(tree.right, lt);
            lt.Add(tree.val);
            return lt;
        }
        static void Main(string[] args)
        {
            var tree = buildTree();
            var result = PostorderTraversal(tree);

            //Recursive 
            // var list = new List<string>();
            // var result  = Postorder_Traversal(tree, list);

            foreach( var item in result)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine("\n finished!");
        }
    }
}


// root -- left -- right
// 反向加入结果 list，每次都在结果 list 的开头加入结点值，
// 而改变先序遍历的顺序就只要该遍历一下入栈顺序，先左后右，这样出栈处理的时候就是先右后左啦