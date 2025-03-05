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
                if (vertex.Value.GetColor() == ColorEnum.White)
                {
                    DFSVisit(vertex.Value);
                }
            }
        }

        private void DFSVisit(VertexCourse node)
        {
            node.SetColor(ColorEnum.Grey);

            foreach (var neighbor in node.GetNeighbors())
            {
                if (neighbor.GetColor() == ColorEnum.Grey)
                {
                    HasCycle = true;
                }
                if (neighbor.GetColor() == ColorEnum.White)
                {
                    neighbor.SetColor(ColorEnum.Grey);

                    DFSVisit(neighbor);
                }
            }
            node.SetColor(ColorEnum.Black);
        }
    }
}
