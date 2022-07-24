namespace Leetcode.Matrix;

public class Search2DMatrix
{
    public static bool Solution(int[][] matrix, int target)
    {
        var i = 0;

        for (; i < matrix.Length; i++)
        {
            if (matrix[i][^1] >= target)
            {
                break;
            }
        }

        if (i >= matrix.Length)
        {
            return false;
        }

        return MatrixBinarySearch(matrix[i], target);
    }

    private static bool MatrixBinarySearch(int[] arr, int target)
    {
        var lp = 0;
        var rp = arr.Length - 1;

        while (lp <= rp)
        {
            var mid = (rp + lp) / 2;

            if (arr[mid] == target)
            {
                return true;
            }
            else if (arr[mid] < target)
            {
                lp = mid + 1;
            }
            else if (arr[rp] > target)
            {
                rp = mid - 1;
            }
        }

        return false;
    }

    // optimixed solution from leetcode discussions
    public static bool SearchMatrix(int[][] matrix, int target)
    {
        int row = matrix.Length - 1, col = 0;
        while (row >= 0 && col < matrix[0].Length)
        {
            if (matrix[row][col] == target)
                return true;
            else if (matrix[row][col] < target)
                col++;
            else if (matrix[row][col] > target)
                row--;
        }
        return false;
    }
}

