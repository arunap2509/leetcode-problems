namespace Leetcode.Miscellaneous;

public class PascalsTriangle
{
    public static IList<IList<int>> Solution(int numRows)
    {
        IList<IList<int>> result = new List<IList<int>>
        {
            new List<int> { 1 }
        };

        for (int i = 1; i < numRows; i++)
        {
            var previous = result[i - 1];

            var currentList = new List<int>();

            for (int j = 0; j <= i; j++)
            {
                if (j == 0)
                {
                    currentList.Add(previous[0]);
                }
                else
                {
                    var aboveLeft = previous[j - 1];
                    var aboveRight = previous.Count > j ? previous[j] : 0;
                    currentList.Add(aboveLeft + aboveRight);
                }
            }

            result.Add(currentList);

        }

        return result;
    }

    public static IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> result = new List<IList<int>>();

        List<int> rows = new();

        for (int i = 0; i < numRows; i++)
        {
            rows.Insert(0, 1);

            for (int j = 1; j < rows.Count - 1; j++)
            {
                rows[j] = rows[j] + rows[j + 1];
            }

            result.Add(new List<int>(rows));
        }

        return result;
    }
}

