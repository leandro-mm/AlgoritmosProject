using System.Diagnostics;

namespace AlgoritmosProject.Services.Graph.Number_Of_Islands;

public class NumberOfIslandsService
{
    public static int NumIslands(char[,] grid)
    {
        if (grid is null || grid.Length == 0)
        {
            return 0;
        }

        int count = 0;

        int rows = grid.GetLength(0);

        int cols = grid.GetLength(1);   

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (grid[i,j] == '1')
                {
                    Debug.WriteLine($"Encontrou 1 no loop principal grid[{i},{j}]: 1");
                    count++;
                    DFS(grid, i, j);
                }
            }
        }
        return count;
    }

    private static void DFS(char[,] grid, int i, int j)
    {
        if (i < 0 || i >= grid.GetLength(0) || j < 0 || j >= grid.GetLength(1) || grid[i,j] == '0')
        {
            return;
        }

        grid[i,j] = '0';
        Debug.WriteLine($"\t grid[{i},{j}]: 0");
        DFS(grid, i + 1, j);
        DFS(grid, i - 1, j);
        DFS(grid, i, j + 1);
        DFS(grid, i, j - 1);
    }
}
