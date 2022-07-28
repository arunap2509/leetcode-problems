namespace Leetcode.Tree;

// BFS for all level order traversal
// Use Queue for bfs
public class LevelOrderTraversal
{
    public static IList<IList<int>> IterativeSolution(TreeNode root)
    {
        IList<IList<int>> result = new List<IList<int>>();

        if (root == null) return result;

        Queue<TreeNode> queue = new();

        queue.Enqueue(root);

        while (queue.Any())
        {
            var size = queue.Count;
            var currentValue = new List<int>();

            for (int i = 0; i < size; i++)
            {
                var current = queue.Dequeue();
                currentValue.Add(current.val);

                if (current.left != null)
                {
                    queue.Enqueue(current.left);
                }

                if (current.right != null)
                {
                    queue.Enqueue(current.right);
                }
            }

            result.Add(currentValue);
        }

        return result;
    }

    public static IList<IList<int>> Solution(TreeNode root)
    {
        IList<IList<int>> result = new List<IList<int>>();

        Helper(root, result, 0);

        return result;
    }

    private static void Helper(TreeNode root, IList<IList<int>> result, int level)
    {
        if (root == null) return;

        if (level == result.Count) result.Add(new List<int>());

        result[level].Add(root.val);

        Helper(root.left, result, level + 1);
        Helper(root.right, result, level + 1);
    }
}

