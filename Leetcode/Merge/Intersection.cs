namespace Leetcode.Merge;

public class Intersection
{
    public class Solution
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            var result = new List<int>();
            var dict = new Dictionary<int, int>();

            if (nums1.Length < nums2.Length)
            {
                (nums1, nums2) = (nums2, nums1);
            }

            for (int i = 0; i < nums1.Length; i++)
            {
                if (dict.ContainsKey(nums1[i]))
                {
                    dict[nums1[i]] += 1;
                }
                else
                {
                    dict.Add(nums1[i], 1);
                }
            }

            for (int j = 0; j < nums2.Length; j++)
            {
                if (dict.ContainsKey(nums2[j]) && dict[nums2[j]] > 0)
                {
                    result.Add(nums2[j]);
                    dict[nums2[j]]--;
                }
            }

            return result.ToArray();
        }
    }
}

