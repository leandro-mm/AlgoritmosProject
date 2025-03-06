using System.Text;

namespace AlgoritmosProject.Services.Graph.Adjacency_List;

public static class AdjacencyListRepresentationService
{
    public static void AddEdge(List<List<int>> adj, int i, int j)
    {
        adj[i].Add(j);
        adj[j].Add(i); // Undirected
    }

    public static string DisplayAdjList(List<List<int>> adj)
    {
        StringBuilder sb = new StringBuilder(); 

        for (int i = 0; i < adj.Count; i++)
        {
            sb.Append($"{i}: "); // Print the vertex
            foreach (int j in adj[i])
            {
                sb.Append($"{j} "); // Print its adjacent
            }
            sb.AppendLine();
        }

        return sb.ToString();      
    }
}
