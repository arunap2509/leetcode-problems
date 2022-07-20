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

    num = 1, t = 2 bucket = 1 / 2 + 1 => 0
    num = 0, t = 2 bucker = 0 / 2 + 1 => 0
    same bucket and they are in range of k so found one

    k = 3
    idx = 0, num = 1, t = 0 bucket = 1 / 0 + 1 => 1
    idx = 1, num = 2, t = 0 bucket = 2 / 0 + 1 => 2
    idx = 2, num = 3, t = 0 bucket = 3 / 0 + 1 => 3
    idx = 3, num = 1, t = 0 bucket = 1 / 0 + 1 => 1

    ans => for index(3-0) is 3 so k condition satisfied also number in same bucket
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

    public static bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
    {

        Dictionary<long, long> buckets = new();

        for (int i = 0; i < nums.Length; i++)
        {
            long bucket = getBucketId(nums[i]);

            // below 3 lines are to compare the value which is less than the t can be in any one of them
            // 2 / 3 => 0
            // 3 / 3 => 1
            if (buckets.ContainsKey(bucket)) return true;

            if (buckets.TryGetValue(bucket - 1, out long leftValue) && Math.Abs(leftValue - nums[i]) <= t) return true;

            if (buckets.TryGetValue(bucket + 1, out long rightValue) && Math.Abs(rightValue - nums[i]) <= t) return true;

            buckets.Add(bucket, nums[i]);

            // to maintain only k buckets
            if (buckets.Count > k) buckets.Remove(getBucketId(nums[i - k]));
        }

        return false;


        int getBucketId(int number)
        {
            int bucketId = number / (t + 1);

            if (number < 0) bucketId--;

            return bucketId;
        }
    }
}

