namespace AlgoritmosProject.Services.Matrix;

public static class SetMatrixToZeroService
{
    public static void SetMatrixToZero(int[][] matrix)
    {
        if (matrix == null || matrix.Length == 0)
            return;
        else if (matrix.Length == 1 && matrix[0].Length == 1)
            return;
        else
        {
            bool[] rowsWithZero = new bool[matrix.Length];

            bool[] colsWithZero = new bool[matrix[0].Length];

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        rowsWithZero[i] = true;
                        colsWithZero[j] = true;
                    }
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (rowsWithZero[i] || colsWithZero[j])
                        matrix[i][j] = 0;
                }
            }
        }
    }

}

