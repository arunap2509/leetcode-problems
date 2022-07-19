namespace Leetcode.ContainsDuplicate;

public class ArrayContainsDuplicateII
{
    public static bool Invoke(int[] nums, int k)
    {
        var dict = new Dictionary<int, List<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                dict[nums[i]].Add(i);

                int count = dict[nums[i]].Count;

                if (Math.Abs(dict[nums[i]][count - 2] - dict[nums[i]][count - 1]) <= k) return true;

                continue;

            }

            dict.Add(nums[i], new() { i });
        }


        return false;
    }
}

