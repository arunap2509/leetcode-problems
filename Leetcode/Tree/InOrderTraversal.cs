namespace Leetcode.Tree;

public class InOrderTraversal
{
    public IList<int> Solution(TreeNode root)
    {
        return Traverse(root, new());
    }

    public IList<int> Traverse(TreeNode node, List<int> arr)
    {
        if (node == null)
        {
            return arr;
        }

        Traverse(node.left, arr);

        arr.Add(node.val);

        Traverse(node.right, arr);

        return arr;
    }

    public static IList<int> IterativeSolution(TreeNode root)
    {
        var result = new List<int>();

        var stack = new Stack<TreeNode>();

        while (root != null || stack.Any())
        {
            while (root != null)
            {
                stack.Push(root);
                root = root.left;
            }

            root = stack.Pop();
            result.Add(root.val);

            root = root.right;
        }

        return result;
    }
}

