namespace AlgoritmosProject.Services.Graph.Course
{
    public class DFS
    {
        private GraphCourse graph;
        public bool HasCycle { get; set; }

        public DFS(GraphCourse graph)
        {
            this.graph = graph;
            HasCycle = false;
        }

        public void PerformDFS()
        {
            foreach (KeyValuePair<int, VertexCourse> vertex in graph.GetVertices())
            {
                if (vertex.Value.GetColor() == Color.WHITE)
                {
                    DFSVisit(vertex.Value);
                }
            }
        }

        private void DFSVisit(VertexCourse node)
        {
            node.SetColor(Color.GREY);

            foreach (VertexCourse neighbor in node.GetNeighbors())
            {
                if (neighbor.GetColor() == Color.GREY)
                {
                    HasCycle = true; break;
                }
                else if (neighbor.GetColor() == Color.WHITE)
                {
                    neighbor.SetColor(Color.GREY);

                    DFSVisit(neighbor);
                }
            }

            node.SetColor(Color.BLACK);
        }
    }
}
