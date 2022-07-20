namespace Leetcode.Sum;

public class TwoSum
{
    public static int[] Solution(int[] nums, int target)
    {
        var result = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    result[0] = i;
                    result[1] = j;

                    break;
                }
            }
        }

        return result;
    }
}

