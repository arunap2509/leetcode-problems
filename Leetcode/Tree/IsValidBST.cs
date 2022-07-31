namespace Leetcode.Tree;

public class IsValidBST
{
    public bool Solution(TreeNode root)
    {
        return IsValidBSTHelper(root, long.MinValue, long.MaxValue);
    }

    private bool IsValidBSTHelper(TreeNode root, long min, long max)
    {
        if (root == null) return true;

        if (root.val >= max || root.val <= min) return false;

        return IsValidBSTHelper(root.left, min, root.val) && IsValidBSTHelper(root.right, root.val, max);
    }

    //  inorder traversal is used to get all the nodes in a sorted order
    // so when we do an inorder and then compare the values, if we find any value less than previous,
    // just return false
    public bool UsingInOrderTraversal(TreeNode root)
    {
        TreeNode? prev = null;
        return Validate(root, prev);
    }

    private bool Validate(TreeNode root, TreeNode? prev)
    {
        if (root == null) return true;

        if (!Validate(root.left, prev)) return false;

        if (prev != null && prev.val >= root.val) return false;

        prev = root;

        return Validate(root.right, prev);
    }

    public static bool UsingInOrderTraversalIterative(TreeNode root)
    {
        if (root == null) return true;

        Stack<TreeNode> stack = new();
        TreeNode? prev = null;

        while (root != null || stack.Any())
        {
            while (root != null)
            {
                stack.Push(root);
                root = root.left;
            }

            root = stack.Pop();

            if (prev != null && prev.val >= root.val) return false;
            prev = root;
            root = root.right;
        }
        return true;
    }
}

