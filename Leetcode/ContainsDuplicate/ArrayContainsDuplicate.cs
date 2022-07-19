namespace Leetcode.ContainsDuplicate;

public class ArrayContainsDuplicate
{
    public static bool Invoke(int[] nums)
    {
        var dict = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (dict.ContainsKey(num))
            {
                return true;
            }

            dict.Add(num, 1);
        }

        return false;
    }
}

