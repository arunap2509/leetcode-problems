namespace Leetcode.BitManipulation;

public class NumberOfOneBits
{
    public static int HammingWeight(uint n)
    {
        int ans = 0;

        while (n != 0)
        {
            n &= (n - 1);
            ans++;
        }

        return ans;
    }
}

