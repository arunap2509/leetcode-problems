namespace Leetcode.Miscellaneous;

public class CountOddNumbersInInterval
{
    public static int Solution(int low, int high)
    {
        // if any of the number is odd then do n/2 + 1
        // else do n/2
        if ((low % 2 != 0) || (high % 2 != 0))
        {
            return (high - low) / 2 + 1;
        }
        else
        {
            return (high - low) / 2;
        }
    }
}

