using System.Xml.Linq;

namespace AlgoritmosProject.Services.Graph.Order_of_Priority;

public class DirectedGraph
{
    private List<VertexOrderOfPriority> vertices = [];

    public void AddEdge(int from, int to, int weight)
    {
        VertexOrderOfPriority? fromVertex = vertices.Find(v => v.GetVertexID() == from);
        VertexOrderOfPriority? toVertex = vertices.Find(v => v.GetVertexID() == to);

        if (fromVertex is null)
        {
            fromVertex = new VertexOrderOfPriority(from);
            vertices.Add(fromVertex);
        }

        if (toVertex is null)
        {
            toVertex = new VertexOrderOfPriority(to);
            vertices.Add(toVertex);
        }

        fromVertex.AddConnection(toVertex, weight);
        toVertex.SetIndegree(toVertex.GetIndegree() + 1);
    }

    public List<VertexOrderOfPriority> GetVertices()
    {
        return vertices;
    }   

    public int[] TopologicalSort()
    {
        if (GetVertices().Count == 0)
        {
            return [0];

        }
        else
        {
            List<int> topological_list = [];

            Queue<VertexOrderOfPriority> topological_queue = [];

            foreach (VertexOrderOfPriority node in GetVertices())
            {
                if (node.GetIndegree() == 0)
                {
                    topological_queue.Enqueue(node);
                }
            }

            while (topological_queue.Count != 0)
            {
                VertexOrderOfPriority current_vertex = topological_queue.Dequeue();

                topological_list.Add(current_vertex.GetVertexID());

                foreach (VertexOrderOfPriority neighbor in current_vertex.GetConnections())
                {
                    neighbor.SetIndegree(neighbor.GetIndegree() - 1);

                    if (neighbor.GetIndegree() == 0)
                    {
                        topological_queue.Enqueue(neighbor);
                    }
                }
            }

            //if (topological_list.Count != GetVertices().Count)
            //{
            //    has_cycle = true;
            //}

            return topological_list.ToArray();
        }
    }
}
