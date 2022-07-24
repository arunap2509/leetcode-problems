namespace Leetcode.Miscellaneous;

public class MostFrequentNumberFollowingKey
{
    public static int MostFrequent(int[] nums, int key)
    {

        var dict = new Dictionary<int, int>();

        var fp = 0;
        var sp = fp;

        while (fp < nums.Length)
        {
            if (nums[fp] == key)
            {
                sp = fp + 1;
                if (sp >= nums.Length)
                {
                    break;
                }

                var target = nums[sp++];

                if (dict.ContainsKey(target))
                {
                    dict[target] += 1;
                }
                else
                {
                    dict.Add(target, 1);
                }

                while (sp < nums.Length && nums[sp] == target)
                {
                    dict[target] += 1;
                    sp++;
                }
            }
            fp++;
        }

        var max = 0;
        var result = 0;

        foreach (var keyValue in dict)
        {
            if (keyValue.Value > max)
            {
                max = keyValue.Value;
                result = keyValue.Key;
            }
        }

        return result;
    }

    public static int MaxFrequentOptimized(int[] nums, int key)
    {
        if (nums.Length < 2)
        {
            return int.MinValue;
        }

        var dict = new Dictionary<int, int>();
        int mostFreq = 0, result = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i-1] == key)
            {
                dict[nums[i]] = dict.GetValueOrDefault(nums[i], 0) + 1;

                if (dict[nums[i]] > mostFreq)
                {
                    mostFreq = dict[nums[i]];
                    result = nums[i];
                }
            }
        }

        return result;
    }
}

