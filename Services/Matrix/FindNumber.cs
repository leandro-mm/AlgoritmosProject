namespace AlgoritmosProject.Services.Matrix;

public static class FindNumber
{
    public static bool FindNumberInMatrix(int[][] matrix, int target)
    {
        if (matrix.Length == 0)
        {
            return false;
        }
        else
        {
            int noRows = matrix.Length;

            int noCols = matrix[0].Length;

            if (target < matrix[0][0] || target > matrix[noRows - 1][noCols - 1])
            {
                return false;
            }

            int r = 0;

            int c = noCols - 1;

            while (r < noRows && c >= 0)
            {
                if (target == matrix[r][c])
                {
                    return true;

                }
                else if (target > matrix[r][c])
                {
                    r += 1;

                }
                else if (target < matrix[r][c])
                {
                    c -= 1;
                }
            }
            return false;
        }
    }
}
