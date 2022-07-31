namespace Leetcode.Tree;

public class FindTarget
{
    public bool Solution(TreeNode root, int k)
    {

        var arr = InOrderHelper(root, new());

        return FindTargetHelper(arr.ToArray(), k);
    }

    public List<int> InOrderHelper(TreeNode root, List<int> arr)
    {

        if (root == null) return arr;

        InOrderHelper(root.left, arr);

        arr.Add(root.val);

        InOrderHelper(root.right, arr);

        return arr;
    }

    public bool FindTargetHelper(int[] arr, int k)
    {

        int lp = 0;
        int rp = arr.Length - 1;

        while (lp < rp)
        {

            if (arr[lp] + arr[rp] == k)
            {
                return true;
            }
            else if (arr[lp] + arr[rp] > k)
            {
                rp--;
            }
            else
            {
                lp++;
            }
        }

        return false;
    }

    public bool SolutionII(TreeNode root, int k)
    {
        HashSet<int> set = new();

        return IsTargetAvailable(root, k, set);
    }

    public bool IsTargetAvailable(TreeNode root, int k, HashSet<int> set)
    {
        if (root == null) return false;

        if (set.Contains(k - root.val)) return true;

        set.Add(root.val);

        return IsTargetAvailable(root.left, k, set) || IsTargetAvailable(root.right, k, set);
    }
}

