using _94_BinaryTReeInorderTraversal;
using System.Collections.Generic;

class Solution2
{
    public static List<string> Inorder_Traversal(TreeNode tree, List<string> list)
    {
        if (tree != null)
        {
            Inorder_Traversal(tree.left, list);
            list.Add(tree.val);
            Inorder_Traversal(tree.right, list);
        }
        return list;
    }
    public static List<string> Inorder_Traversal2(TreeNode tree, List<string> list)
    {
        if (tree == null)
            return list;
        if (tree.left != null)
            Inorder_Traversal2(tree.left, list);

        list.Add(tree.val);

        if (tree.right != null)
            Inorder_Traversal2(tree.right, list);

        return list;        
    }
}