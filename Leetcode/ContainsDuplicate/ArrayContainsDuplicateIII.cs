namespace Leetcode.ContainsDuplicate;

public class ArrayContainsDuplicateIII
{
    /*
     Given an integer array nums and two integers k and t, return true if there are two distinct
     indices i and j in the array such that abs(nums[i] - nums[j]) <= t and abs(i - j) <= k

    Input: nums = [1,2,3,1], k = 3, t = 0
    Output: true

    Input: nums = [1,0,1,1], k = 1, t = 2
    Output: true

    Input: nums = [1,5,9,1,5,9], k = 2, t = 3
    Output: false
    */

    // throws time limit exceeded
    public static bool Invoke(int[] nums, int k, int t)
    {
        var pointer = 0;

        /*

        by checking if all the elements are unique and t is 0 then we can
        pass all the test cases by it will take too long
        
        SortedSet<int> set = new(nums);

        if (t == 0 && set.Count == nums.Length) return false;
        */

        for (int i = 1; i < nums.Length; i++)
        {
            while (pointer < i)
            {
                if ((Math.Abs((long)nums[pointer] - nums[i]) <= t) && (Math.Abs(pointer - i) <= k))
                {
                    return true;
                }

                pointer++;
            }

            // if i is greater then k then move the pointer to
            // i - k + 1 so that for the next i we will be correct position
            pointer = i > k ? i - k + 1 : 0;
        }

        return false;
    }
}

