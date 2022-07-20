namespace Leetcode.Merge;

public class MergeSortedArray
{
    public static void Merge(int[] nums1, int n, int[] nums2, int m)
    {
        var i = n - 1;
        var j = m - 1;
        var k = n + m - 1;

        while (i >= 0 && j >= 0)
        {
            if (nums1[i] <= nums2[j])
            {
                nums1[k--] = nums2[j--];
            }
            else
            {
                nums1[k--] = nums1[i--];
            }
        }

        while (j >= 0)
        {
            nums1[k--] = nums2[j--];
        }

        Console.WriteLine(string.Join(",", nums1));
    }
}

