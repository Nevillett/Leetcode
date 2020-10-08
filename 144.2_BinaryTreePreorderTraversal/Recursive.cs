using _144._2_BinaryTreePreorderTraversal;
using System.Collections.Generic;

class Solution2
{
    public static List<string> Preorder_Traversal(Program.TreeNode tree, List<string> list)    
    {
        if (tree == null)
            return list;
        list.Add(tree.val);

        if (tree.left != null)
            Preorder_Traversal(tree.left, list);

        if (tree.right != null)
            Preorder_Traversal(tree.right, list);

        //System.Console.WriteLine("Recursive");            
        return list;
    }
}