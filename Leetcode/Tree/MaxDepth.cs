namespace Leetcode.Tree;

public class MaxDepth
{
    public int Solution(TreeNode root)
    {
        if (root == null) return 0;

        var leftHeight = Solution(root.left);
        var rightHeight = Solution(root.right);

        return 1 + Math.Max(leftHeight, rightHeight);
    }
}

