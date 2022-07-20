namespace Leetcode.ContiguousSubArray;

public class MaximumSubArray
{
    // kadane's algorithm
    public static int MaxSubArray(int[] nums)
    {

        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0];

        var sum = 0;
        // initialize it with first value so when all the nums are negative the result wont be 0
        var maxSum = nums[0];

        for (int i = 0; i < nums.Length; i++)
        {
            // first check for this condition so that the maxsum wont get updated to zero in case of all negative
            if (sum < 0)
            {
                sum = 0;
            }

            sum += nums[i];

            maxSum = Math.Max(maxSum, sum);
        }

        return maxSum;
    }
}

