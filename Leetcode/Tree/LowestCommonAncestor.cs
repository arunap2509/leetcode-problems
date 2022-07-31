#pragma warning disable CS8603
namespace Leetcode.Tree;

public class LowestCommonAncestor
{
    public TreeNode Solution(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root == null || root == p || root == q)
        {
            return root;
        }

        var left = Solution(root.left, p, q);
        var right = Solution(root.right, p, q);

        if (left == null)
        {
            return right;
        }
        else if (right == null)
        {
            return left;
        }
        else
        {
            return root;
        }
    }
}

