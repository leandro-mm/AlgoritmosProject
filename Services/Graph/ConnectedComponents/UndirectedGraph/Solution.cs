namespace AlgoritmosProject.Services.Graph.ConnectedComponents.UndirectedGraph;

public class Solution
{
    public int CountComponents(int n, IList<List<int>> edges)
    {
        if (n == 1 && edges.Count == 0)
        {
            return 1;
        }            
        else
        {
            Graph G = new();

            foreach (List<int> entry in edges)
            {
                G.AddEdge(entry[0], entry[1], 1);
            }
                
            int count = 0;

            foreach (Vertex vertex in G)
            {
                if (vertex.GetColor() == Color.WHITE)
                {
                    count++;
                    BFS(vertex);
                }
            }
            return count;
        }
    }

    private void BFS(Vertex vertex)
    {
        vertex.SetColor(Color.GREY);

        Queue<Vertex> queue = new();

        queue.Enqueue(vertex);

        while (queue.Count != 0)
        {
            Vertex currNode = queue.Dequeue();

            foreach (Vertex nbr in currNode.GetConnections())
            {
                if (nbr.GetColor() == Color.WHITE)
                {
                    nbr.SetColor(Color.GREY);
                    queue.Enqueue(nbr);
                }
            }
            currNode.SetColor(Color.BLACK);
        }
    }
}
