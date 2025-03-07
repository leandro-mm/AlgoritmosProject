namespace AlgoritmosProject.Services.Graph.Order_of_Priority;

public class VertexOrderOfPriority
{
    private int vertexID;
    private Dictionary<VertexOrderOfPriority, int> connections = [];
    private int indegree = 0;

    public VertexOrderOfPriority(int id)
    {
        vertexID = id;
    }

    public int GetVertexID()
    {
        return vertexID;
    }

    public void AddConnection(VertexOrderOfPriority neighbor, int weight)
    {
        connections[neighbor] = weight;
    }

    public List<VertexOrderOfPriority> GetConnections()
    {
        return new List<VertexOrderOfPriority>(connections.Keys);
    }

    public int GetIndegree()
    {
        return indegree;
    }

    public void SetIndegree(int value)
    {
        indegree = value;
    }
}
