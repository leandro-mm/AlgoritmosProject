namespace AlgoritmosProject.Services.Graph.Course
{
    public class VertexCourse(int key)
    {
        private int vertexId = key;
        private Dictionary<VertexCourse, int> adjacentVertices = [];
        private int indegreeCount = 0;
        private int outdegreeCount = 0;
        private VertexCourse? predecessorVertex = null;
        private int visitTime = 0;
        private int finishTime = 0;
        private string vertexColor = ColorEnum.White;

        public void AddNeighbor(VertexCourse neighbor, int weight = 0)
        {
            adjacentVertices[neighbor] = weight;
        }

        public IEnumerable<VertexCourse> GetNeighbors()
        {
            return adjacentVertices.Keys;
        }

        public int GetId()
        {
            return vertexId;
        }

        public int GetWeight(VertexCourse neighbor)
        {
            return adjacentVertices[neighbor];
        }

        public int GetIndegree()
        {
            return indegreeCount;
        }

        public void SetIndegree(int indegree)
        {
            indegreeCount = indegree;
        }

        public int GetOutdegree()
        {
            return outdegreeCount;
        }

        public void SetOutdegree(int outdegree)
        {
            outdegreeCount = outdegree;
        }

        public VertexCourse GetPredecessor()
        {
            return predecessorVertex;
        }

        public void SetPredecessor(VertexCourse predecessor)
        {
            predecessorVertex = predecessor;
        }

        public int GetVisitTime()
        {
            return visitTime;
        }

        public void SetVisitTime(int visitTime)
        {
            this.visitTime = visitTime;
        }

        public int GetFinishTime()
        {
            return finishTime;
        }

        public void SetFinishTime(int finishTime)
        {
            this.finishTime = finishTime;
        }

        public string GetColor()
        {
            return vertexColor;
        }

        public void SetColor(string color)
        {
            vertexColor = color;
        }

        public override string ToString()
        {
            return vertexId + " connectedTo: " + string.Join(", ", adjacentVertices.Keys);
        }
    }
}
