#pragma warning disable CS8603

namespace Leetcode.Tree;

public class InvertTree
{
    public static TreeNode Solution(TreeNode root)
    {
        if (root == null) return root;

        Stack<TreeNode> stack = new();

        var result = root;

        stack.Push(root);

        while (stack.Any())
        {
            root = stack.Pop();

            (root.right, root.left) = (root.left, root.right);
            if (root.right != null) stack.Push(root.right);
            if (root.left != null) stack.Push(root.left);
        }

        return result;
    }

    public TreeNode RecursiveSolution(TreeNode root)
    {
        if (root == null)
        {
            return root;
        }

        var left = root.left;
        root.left = RecursiveSolution(root.right);
        root.right = RecursiveSolution(left);

        return root;

    }

    public TreeNode AnotherRecursiveSolution(TreeNode root)
    {
        if (root == null) return root;

        TreeNode left = AnotherRecursiveSolution(root.left);
        TreeNode right = AnotherRecursiveSolution(root.right);

        root.right = left;
        root.left = right;

        return root;
    }
}

