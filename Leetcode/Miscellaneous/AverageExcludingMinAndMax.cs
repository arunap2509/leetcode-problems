namespace Leetcode.Miscellaneous;

public class AverageExcludingMinAndMax
{
    public static double Solution(int[] salary)
    {
        Array.Sort(salary);

        var sum = salary.Sum() - salary[0] - salary[salary.Length - 1];

        return sum / (salary.Length - 2);
    }

    public static double Average(int[] salary)
    {

        var min = double.MaxValue;
        var max = double.MinValue;
        double sum = 0;

        foreach (var num in salary)
        {
            min = Math.Min(min, num);
            max = Math.Max(max, num);
            sum += num;
        }

        return (sum - min - max) / (salary.Length - 2);
    }
}

