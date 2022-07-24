namespace Leetcode.String;

public class FirstUniqueChar
{
    public static int Solution(string s)
    {
        var dict = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            dict[s[i]] = dict.GetValueOrDefault(s[i], 0) + 1;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (dict[s[i]] == 1)
            {
                return i;
            }
        }

        return -1;
    }

    // using char array to solve the problem
    public static int FirstUniqChar(string s)
    {
        int[] freq = new int[26];
        for (int i = 0; i < s.Length; i++)
            freq[s[i] - 'a']++;
        for (int i = 0; i < s.Length; i++)
            if (freq[s[i] - 'a'] == 1)
                return i;
        return -1;
    }
}

