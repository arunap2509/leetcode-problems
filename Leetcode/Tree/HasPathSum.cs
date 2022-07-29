#pragma warning disable CS8604

namespace Leetcode.Tree;

public class HasPathSum
{
    public bool Solution(TreeNode root, int targetSum)
    {
        return HasPathSumHelper(root, targetSum, 0);
    }

    private bool HasPathSumHelper(TreeNode root, int targetSum, int currentSum)
    {
        if (root == null) return false;

        currentSum += root.val;

        if (root.left == null && root.right == null && currentSum == targetSum)
        {
            return true;
        }

        return HasPathSumHelper(root.left, targetSum, currentSum)
            || HasPathSumHelper(root.right, targetSum, currentSum);
    }

    // dont always have to add or bring in another variable
    // can also work with subtraction
    public bool AnotherSolution(TreeNode root, int targetSum)
    {
        if (root == null) return false;

        if (root.left == null && root.right == null && targetSum - root.val == 0) return true;

        return AnotherSolution(root.left, targetSum - root.val)
            || AnotherSolution(root.right, targetSum - root.val);
    }
}

