namespace Leetcode.Tree;

public class IsSymmetric
{
    public static bool Solution(TreeNode root)
    {
        if (root == null) return true;

        return SymmetryHelper(root.left, root.right);
    }

    private static bool SymmetryHelper(TreeNode root1, TreeNode root2)
    {

        if (root1 == null && root2 == null)
        {
            return true;
        }

        if (root1 == null || root2 == null)
        {
            return false;
        }

        if (root1.val != root2.val)
        {
            return false;
        }

        return SymmetryHelper(root1.left, root2.right)
            && SymmetryHelper(root1.right, root2.left);
    }
}

