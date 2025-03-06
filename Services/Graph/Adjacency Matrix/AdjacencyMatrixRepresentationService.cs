using System.Text;

namespace AlgoritmosProject.Services.Graph.Adjacency_Matrix
{
    public static class AdjacencyMatrixRepresentationService
    {
        // Add an edge between two vertices
        public static void AddEdge(int[,] mat, int i, int j)
        {
            mat[i, j] = 1; // Since the graph is 
            mat[j, i] = 1; // undirected
        }

        // Display the adjacency matrix
        public static string DisplayMatrix(int[,] mat)
        {
            StringBuilder sb = new StringBuilder();

            int V = mat.GetLength(0);
            for (int i = 0; i < V; i++)
            {
                for (int j = 0; j < V; j++)
                {
                    sb.Append(mat[i, j] + " ");
                }

                sb.AppendLine();
            }

            return sb.ToString();   
        }
    }
}
