namespace AlgoritmosProject.Services.Matrix
{
    public static class RotateMatrixService
    {
        public static void RotateMatrixII(int[][] matrix)
        {
            if(matrix is null || matrix.Length == 0 || matrix[0].Length != matrix[1].Length)
                return;

            int n = matrix.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }

            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (n/2); j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[i][n-1-j];
                    matrix[i][n - 1 - j] = temp;
                }
            }
        }
        public static void RotateMatrixI(int[][] matrix)
        {
            if (matrix is null || matrix.Length == 0)
                return;

            int lines = matrix.Length;

            for (int i = 0; i < (lines / 2); i++)
            {
                int pointer1 = i;

                int pointer2 = lines - 1 - i;

                for (int j = pointer1; j < pointer2; j++)
                {
                    int index = j - pointer1;

                    int value = matrix[pointer1][j];

                    matrix[pointer1][j] = matrix[pointer2 - index][pointer1];

                    matrix[pointer2 - index][pointer1] = matrix[pointer2][pointer2 - index];

                    matrix[pointer2][pointer2 - index] = matrix[j][pointer2];

                    matrix[j][pointer2] = value;
                }
            }
        }
    }
}
