namespace Leetcode.String;

public class IsAnagram
{
    public static bool Solution(string s, string t)
    {

        var sFreq = new Dictionary<char, int>();
        var tFreq = new Dictionary<char, int>();

        if (t.Length != s.Length)
        {
            return false;
        }

        for (int i = 0; i < s.Length; i++)
        {
            sFreq[s[i]] = sFreq.GetValueOrDefault(s[i], 0) + 1;
        }

        for (int i = 0; i < t.Length; i++)
        {
            tFreq[t[i]] = tFreq.GetValueOrDefault(t[i], 0) + 1;
        }

        foreach (var keyValue in sFreq)
        {
            if (keyValue.Value != tFreq.GetValueOrDefault(keyValue.Key, 0))
            {
                return false;
            }
        }

        return true;
    }
}

