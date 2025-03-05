namespace AlgoritmosProject.Services.Graph.Course
{
    public class GraphCourse
    {
        private Dictionary<int, VertexCourse> vertexDictionary;
        private int numberOfVertices;
        private int numberOfEdges;

        public GraphCourse()
        {
            vertexDictionary = new Dictionary<int, VertexCourse>();
            numberOfVertices = 0;
            numberOfEdges = 0;
        }

        public VertexCourse? AddVertex(int vertexKey)
        {
            if (!vertexDictionary.ContainsKey(vertexKey))
            {
                VertexCourse newVertexObject = new VertexCourse(vertexKey);
                vertexDictionary[vertexKey] = newVertexObject;
                numberOfVertices++;
            }

            return vertexDictionary[vertexKey];

        }

        public VertexCourse? GetVertex(int vertexKey)
        {
            if (vertexDictionary.ContainsKey(vertexKey))
            {
                return vertexDictionary[vertexKey];
            }
            else
            {
                return null;
            }
        }

        public void AddEdge(int vertex1Key, int vertex2Key, int weight = 1)
        {
            VertexCourse? vertex1 = AddVertex(vertex1Key);

            VertexCourse? vertex2 = AddVertex(vertex2Key);

            vertex1?.AddNeighbor(vertex2, weight);
            
            vertex1?.SetOutdegree(vertex1.GetOutdegree() + 1);
            
            vertex2?.SetIndegree(vertex2.GetIndegree() + 1);

            numberOfEdges++;
        }

        public List<(int, int, int)> GetEdges()
        {
            List<(int, int, int)> edges = [];

            foreach (KeyValuePair<int, VertexCourse> KeyValuePairVertex in vertexDictionary)
            {
                foreach (VertexCourse vertexCourse in KeyValuePairVertex.Value.GetNeighbors())
                {
                    int key = KeyValuePairVertex.Key;
                    int vertexCourseId = vertexCourse.GetId();
                    edges.Add((key, vertexCourseId, KeyValuePairVertex.Value.GetWeight(vertexCourse)));
                }
            }
            return edges;
        }

        public Dictionary<int, VertexCourse> GetVertices()
        {
            return vertexDictionary;
        }
    }
}
