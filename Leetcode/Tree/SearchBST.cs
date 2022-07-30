#pragma warning disable CS8603

namespace Leetcode.Tree;

public class SearchBST
{
    public static TreeNode IterativeSolution(TreeNode root, int val)
    {

        if (root == null) return root;

        Stack<TreeNode> stack = new();

        stack.Push(root);

        while (stack.Any())
        {
            var current = stack.Pop();

            if (current.val == val) return current;

            if (current.left != null) stack.Push(current.left);

            if (current.right != null) stack.Push(current.right);
        }

        return null;
    }

    public TreeNode RecursiveSolution(TreeNode root, int val)
    {

        if (root == null) return root;

        if (root.val == val) return root;

        var leftSearch = RecursiveSolution(root.left, val);

        if (leftSearch != null) return leftSearch;

        var rightSearch = RecursiveSolution(root.right, val);

        return rightSearch;
    }
}

