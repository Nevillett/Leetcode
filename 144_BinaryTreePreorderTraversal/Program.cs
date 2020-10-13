using System;
using System.Collections;
using System.Collections.Generic;

namespace _144_BinaryTreePreorderTraversal
{
    class Program
    {    
        public class TreeNode
        {
            public int val;
            public string val2;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val)
            {
                this.val = val;
                this.left = null;
                this.right = null;
            }
            //constructor overloading
            public TreeNode(string val2)
            {
                this.val2 = val2;
                this.left = this.right = null;
            }
        }        
        public static IList<int> PreorderTraversal(TreeNode root)
        {
            Stack<TreeNode> stk = new Stack<TreeNode>();
            List<int> lt = new List<int>();

            stk.Push(root);
            while(stk.Count > 0)
            {            
                var current = stk.Pop();
                lt.Add(current.val);                

                if(current.right != null)
                    stk.Push(current.right);
                if(current.left != null)
                    stk.Push(current.left);
            }
            return lt;
        }
        //only use TreeNode to build a binary tree
        public static TreeNode buildTree()
        {
            TreeNode tree = new TreeNode(1);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(3);
            tree.left.left = new TreeNode(4);
            return tree;
        }

/*
        public class BinaryTree
        {
            public TreeNode root;
            public BinaryTree(string val)
            {
                root = new TreeNode(val);                
            }
            public BinaryTree()
            {
                root = null;
            }
        }         
        // Use BinaryTree to build a binary tree which has root node
        public static BinaryTree buildBinaryTree()
        {
            BinaryTree tree = new BinaryTree("F");
            tree.root.left = new TreeNode("B");
            tree.root.right = new TreeNode("G");
            tree.root.left.left = new TreeNode("A");
            tree.root.left.right = new TreeNode("D");
            tree.root.left.right.left = new TreeNode("C");
            tree.root.left.right.right = new TreeNode("E");
            tree.root.right.right = new TreeNode("I");
            tree.root.right.right.left = new TreeNode("H");
            return tree;
        }
        public static IList<string> PreorderTraversal_2(TreeNode root)
        {
            Stack<TreeNode> stk = new Stack<TreeNode>();
            List<string> lt = new List<string>();

            stk.Push(root);
            while(stk.Count > 0)
            {            
                var current = stk.Pop();
                lt.Add(current.val2);                

                if(current.right != null)
                    stk.Push(current.right);
                if(current.left != null)
                    stk.Push(current.left);
            }
            return lt;
        }        
*/        
            static void Main(string[] args)
            {
                var test = buildTree();        
                var result = PreorderTraversal(test);

                // BinaryTree testStringTree = b.buildBinaryTree();
                // var result = b.PreorderTraversalB(testStringTree.root);
                
                foreach(var item in result)
                {
                    Console.Write(item + "  ");                
                }            
                Console.WriteLine("\n finished");
            }
        }
    }
