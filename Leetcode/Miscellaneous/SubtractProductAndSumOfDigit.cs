namespace Leetcode.Miscellaneous;

public class SubtractProductAndSumOfDigit
{
    public static int SubtractProductAndSum(int n)
    {
        if (n == 0) return n;

        var product = 1;
        var sum = 0;

        while (n != 0)
        {
            var digit = n % 10;
            n /= 10;

            product *= digit;
            sum += digit;
        }

        return product - sum;
    }
}

