namespace AlgoritmosProject.Services.Graph.ConnectedComponents.UndirectedGraph;

public class Vertex
{
    public int id;
    public Dictionary<Vertex, int> adjacent;
    public int distance;
    public bool visited;
    public string color;
    public Vertex previous;

    public Vertex(int node)
    {
        id = node;
        adjacent = new Dictionary<Vertex, int>();
        distance = int.MaxValue;
        visited = false;
        color = "white";
        previous = null;
    }

    public void AddNeighbor(Vertex neighbor, int weight = 0)
    {
        adjacent[neighbor] = weight;
    }

    public IEnumerable<Vertex> GetConnections()
    {
        return adjacent.Keys;
    }

    public int GetVertexID()
    {
        return id;
    }

    public int GetWeight(Vertex neighbor)
    {
        return adjacent[neighbor];
    }

    public void SetDistance(int dist)
    {
        distance = dist;
    }

    public int GetDistance()
    {
        return distance;
    }

    public void SetColor(string color)
    {
        this.color = color;
    }

    public string GetColor()
    {
        return color;
    }

    public void SetPrevious(Vertex prev)
    {
        previous = prev;
    }

    public void SetVisited()
    {
        visited = true;
    }

    public override string ToString()
    {
        return id + " adjacent: " + string.Join(", ", adjacent.Keys);
    }
}
