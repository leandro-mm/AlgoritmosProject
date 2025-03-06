namespace AlgoritmosProject.Services.Graph.Valid_Tree;

public class ValidTreeService
{
    private HashSet<int> visited = [];

    private Dictionary<int, List<int>> graph = [];

    public bool ValidTree(int n, IList<List<int>> edges)
    {
        graph = BuildGraph(edges);
        
        return DFS(0) && visited.Count == n && edges.Count == n - 1;
    }

    private Dictionary<int, List<int>> BuildGraph(IList<List<int>> edges)
    {
        Dictionary<int, List<int>> graph = [];

        foreach (IList<int> edge in edges)
        {
            int src = edge[0];

            int dest = edge[1];

            if (!graph.ContainsKey(src))
            {
                graph[src] = [];
            }

            if (!graph.ContainsKey(dest))
            {
                graph[dest] = [];
            }

            graph[src].Add(dest);

            graph[dest].Add(src);
        }

        return graph;
    }
    private bool DFS(int root)
    {
        visited.Add(root);

        foreach (int node in graph[root])
        {
            if (visited.Contains(node))
            {
                continue;
            }
            if (!DFS(node))
            {
                return false;
            }
        }
        return true;
    }
}
