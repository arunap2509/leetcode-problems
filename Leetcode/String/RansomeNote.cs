namespace Leetcode.String;

public class RansomeNote
{
    public static bool CanConstruct(string ransomNote, string magazine)
    {

        int[] magazineFreq = new int[26];

        for (int i = 0; i < magazine.Length; i++)
        {
            magazineFreq[magazine[i] - 'a']++;
        }

        for (int i = 0; i < ransomNote.Length; i++)
        {
            if (magazineFreq[ransomNote[i] - 'a'] == 0)
            {
                return false;
            }
            magazineFreq[ransomNote[i] - 'a']--;
        }

        return true;
    }
}

