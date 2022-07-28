namespace Leetcode.Tree;

public class PreOrderTraversal
{
    public static IList<int> Solution(TreeNode root)
    {

        return Traverse(root, new());
    }

    public static IList<int> Traverse(TreeNode node, List<int> arr)
    {
        if (node == null)
        {
            return arr;
        }

        arr.Add(node.val);

        Traverse(node.left, arr);

        Traverse(node.right, arr);

        return arr;
    }

    public static IList<int> IterativeSolution(TreeNode root)
    {
        List<int> result = new();

        if (root == null) return result;

        Stack<TreeNode> stack = new();

        stack.Push(root);

        while(stack.Any())
        {
            var current = stack.Pop();

            result.Add(current.val);

            if (current.right != null)
            {
                stack.Push(current.right);
            }

            if (current.left != null)
            {
                stack.Push(current.left);
            }
        }

        return result;
    }
}

