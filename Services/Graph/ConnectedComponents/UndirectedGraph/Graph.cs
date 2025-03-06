namespace AlgoritmosProject.Services.Graph.ConnectedComponents.UndirectedGraph
{
    public class Graph
    {
        private Dictionary<int, Vertex> vertDictionary;
        private int numVertices;

        public Graph()
        {
            vertDictionary = new Dictionary<int, Vertex>();
            numVertices = 0;
        }

        public IEnumerator<Vertex> GetEnumerator()
        {
            return vertDictionary.Values.GetEnumerator();
        }

        public Vertex AddVertex(int node)
        {
            numVertices++;
            Vertex newVertex = new Vertex(node);
            vertDictionary[node] = newVertex;
            return newVertex;
        }

        public Vertex? GetVertex(int n)
        {
            if (vertDictionary.ContainsKey(n))
                return vertDictionary[n];
            else
                return null;
        }

        public void AddEdge(int from, int to, int cost = 0)
        {
            if (!vertDictionary.ContainsKey(from))
                AddVertex(from);
            if (!vertDictionary.ContainsKey(to))
                AddVertex(to);
            vertDictionary[from].AddNeighbor(vertDictionary[to], cost);
            vertDictionary[to].AddNeighbor(vertDictionary[from], cost);
        }

        public IEnumerable<int> GetVertices()
        {
            return vertDictionary.Keys;
        }

        public void SetPrevious(Vertex current)
        {
            previous = current;
        }

        public Vertex GetPrevious(Vertex current)
        {
            return previous;
        }

        private Vertex previous;
    }
}
