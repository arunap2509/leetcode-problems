namespace Leetcode.Tree;

public class InsertIntoBST
{
    public TreeNode RecursiveSolution(TreeNode root, int val)
    {

        if (root == null) return new(val);

        if (root.val > val)
        {
            root.left = RecursiveSolution(root.left, val);
        }
        else
        {
            root.right = RecursiveSolution(root.right, val);
        }

        return root;
    }

    public static TreeNode IterativeSolution(TreeNode root, int val)
    {
        if (root == null) return new(val);

        var result = root;

        while(true)
        {
            if (root.val > val)
            {
                if (root.left == null)
                {
                    root.left = new(val);
                    break;
                }
                else
                {
                    root = root.left;
                }
            }
            else
            {
                if (root.right == null)
                {
                    root.right = new(val);
                    break;
                }
                else
                {
                    root = root.right;
                }
            }
        }

        return result;
    }
}

