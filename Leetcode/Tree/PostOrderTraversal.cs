namespace Leetcode.Tree;

public class PostOrderTraversal
{
    public static IList<int> Solution(TreeNode root)
    {
        return Traverse(root, new());
    }

    public static IList<int> Traverse(TreeNode node, List<int> arr)
    {
        if (node == null) return arr;

        Traverse(node.left, arr);

        Traverse(node.right, arr);

        arr.Add(node.val);

        return arr;
    }

    public static IList<int> IterativeSolution(TreeNode root)
    {
        List<int> result = new();

        if (root == null) return result;

        Stack<TreeNode> stack = new();

        while (root != null || stack.Any())
        {
            if (root != null)
            {
                stack.Push(root);
                root = root.left;
            }
            else
            {
                var temp = stack.Peek().right;

                if (temp == null)
                {
                    temp = stack.Pop();
                    result.Add(temp.val);

                    while (stack.Any() && temp == stack.Peek().right)
                    {
                        temp = stack.Pop();
                        result.Add(temp.val);
                    }
                }
                else
                {
                    root = temp;
                }
            }
        }

        return result;
    }
}

