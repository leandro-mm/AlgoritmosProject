namespace AlgoritmosProject.Services.Matrix;

public static class SpiralMAtrix
{
    public static IList<int> SpiralOrder(int[][] matrix)
    {
        List<int> spiral = [];

        if (matrix.Length == 0)
        {
            return spiral;
        }
        else
        {
            // no of rows
            int rowsCount = matrix.Count();

            // no of columns
            int columnsCount = matrix[0].Count();

            // starting row
            int linha = 0;

            // starting column
            int column = 0;

            while (linha < rowsCount && column < columnsCount)
            {
                // print the first row from the remaining rows
                for (int i = column; i < columnsCount; i++)
                {
                    spiral.Add(matrix[linha][i]);
                }
                    
                linha++;

                // print the last column from the remaining column
                for (int i = linha; i < rowsCount; i++)
                {
                    spiral.Add(matrix[i][columnsCount - 1]);
                }
                    
                columnsCount--;

                // print the last row from the remaining rows
                if (linha < rowsCount)
                {
                    for (int i = columnsCount - 1; i >= column; i--)
                    {
                        spiral.Add(matrix[rowsCount - 1][i]);
                    }
                        
                    rowsCount--;
                }
            }
           

                return spiral;
        }
    }

}
