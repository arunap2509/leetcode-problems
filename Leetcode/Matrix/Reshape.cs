namespace Leetcode.Matrix;

public class Reshape
{
    public static int[][] MatrixReshape(int[][] mat, int r, int c)
    {
        var row = mat.Length;
        var col = mat[0].Length;

        if ((row * col) != (r * c))
        {
            return mat;
        }

        var result = new int[r][];

        for (int i = 0; i < result.GetLength(0); i++)
        {
            result[i] = new int[c];
        }

        
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                // gives the elements current position in the array linerly
                int current = i * col + j;

                // can get you the position in the resultant array
                result[current / c][current % c] = mat[i][j];
            }
        }

        return result;
    }
}

