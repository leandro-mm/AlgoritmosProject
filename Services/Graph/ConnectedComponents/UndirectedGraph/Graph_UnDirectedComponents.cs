using System.Text;

namespace AlgoritmosProject.Services.Graph.ConnectedComponents.UndirectedGraph;

public class Graph_UnDirectedComponents
{

    private int NumberOfVertices;
    private List<List<int>> AdjListArray;

    public Graph_UnDirectedComponents(int numberOfVertices)
    {
        NumberOfVertices = numberOfVertices;

        AdjListArray = new List<List<int>>(numberOfVertices);

        for (int i = 0; i < numberOfVertices; i++)
        {
            AdjListArray.Add([]);
        }
    }

    public void AddEdge(int src, int dest)
    {
        // Add an edge from src to dest.
        AdjListArray[src].Add(dest);

        // Since graph is undirected        
        AdjListArray[dest].Add(src);
    }

    private void DFSUtil(int v, bool[] visited, StringBuilder stringBuilder)
    {
        // Mark the current node as visited and print it
        visited[v] = true;

        stringBuilder.Append(v + " ");

        // Recur for all the vertices
        // adjacent to this vertex
        foreach (int x in AdjListArray[v])
        {
            if (!visited[x])
                DFSUtil(x, visited, stringBuilder);
        }
    }

    public string GetConnectedComponents()
    {
        // Mark all the vertices as not visited
        bool[] visited = new bool[NumberOfVertices];

        StringBuilder stringBuilder = new();

        for (int v = 0; v < NumberOfVertices; ++v)
        {
            if (!visited[v])
            {
                // print all reachable vertices
                // from v
                DFSUtil(v, visited, stringBuilder);
                stringBuilder.AppendLine();
            }
        }

        return stringBuilder.ToString();
    }

}
