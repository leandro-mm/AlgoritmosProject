using System.Text;

namespace AlgoritmosProject.Services.Graph;

public class AdjascentList_BFS_DFS
{
    private int vertex;
    private List<int>[] adjacentLIst;

    public AdjascentList_BFS_DFS(int value)
    {
        vertex = value;
        adjacentLIst = new List<int>[value];

        for (int i = 0; i< value; i++)
        {
            adjacentLIst[i] = [];
        }
    }

    public void AddEdge(int index, int weight)
    {
        adjacentLIst[index].Add(weight);
    }

    public string BFS(int start)
    {
        StringBuilder stringBuilder = new();
        stringBuilder.AppendLine("DFS using a Queue and a bool[] visited control");
        stringBuilder.AppendLine();

        bool[] visited = new bool[vertex];

        Queue<int> q = new();

        visited[start] = true;

        q.Enqueue(start);

        while (q.Count != 0)
        {
            int currNode = q.Dequeue();

            stringBuilder.AppendLine($"next -> {currNode}");

            foreach (int nbr in adjacentLIst[currNode])
            {
                if (!visited[nbr])
                {
                    visited[nbr] = true;
                    q.Enqueue(nbr);
                }
            }
        }

        return stringBuilder.ToString();
    }

    public string DFS(int start)
    {
        StringBuilder stringBuilder = new();
        stringBuilder.AppendLine("DFS using a Stack and a bool[] visited control");
        stringBuilder.AppendLine();

        bool[] visited = new bool[vertex];

        Stack<int> s = new();

        visited[start] = true;

        s.Push(start);

        while (s.Count != 0)
        {
            int currNode = s.Pop();

            stringBuilder.AppendLine($"next -> {currNode}");

            foreach (var nbr in adjacentLIst[currNode])
            {
                if (!visited[nbr])
                {
                    visited[nbr] = true;

                    s.Push(nbr);
                }
            }
        }

        return stringBuilder.ToString();
    }

    public string PrintAdjacentList()
    {
        StringBuilder stringBuilder = new();

        for (int i = 0; i < vertex; i++)
        {
            stringBuilder.Append($"Vertex {i} [");

            foreach (var item in adjacentLIst[i])
            {
                stringBuilder.Append($"{item},");
            }
            stringBuilder.AppendLine("]");
        }

        return stringBuilder.ToString();
    }

}
