using System.Text;

namespace AlgoritmosProject.Services.Graph
{
    public class GraphII
    {
        private int vertex;
        private List<int>[] adjacent;

        public GraphII(int value)
        {
            vertex = value;
            adjacent = new List<int>[value];

            for (int i = 0; i< value; i++)
            {
                adjacent[i] = [];
            }
        }

        public void AddEdge(int index, int weight)
        {
            adjacent[index].Add(weight);
        }

        public string BFS(int start)
        {
            StringBuilder stringBuilder = new();

            bool[] visited = new bool[vertex];

            Queue<int> q = new Queue<int>();

            visited[start] = true;

            q.Enqueue(start);

            while (q.Count != 0)
            {
                int currNode = q.Dequeue();

                stringBuilder.AppendLine($"next -> {currNode}");

                foreach (var nbr in adjacent[currNode])
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

            bool[] visited = new bool[vertex];

            Stack<int> s = new Stack<int>();

            visited[start] = true;

            s.Push(start);

            while (s.Count != 0)
            {
                int currNode = s.Pop();

                stringBuilder.AppendLine($"next -> {currNode}");

                foreach (var nbr in adjacent[currNode])
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

        public string PrintAdjacentMatrix()
        {
            StringBuilder stringBuilder = new();

            for (int i = 0; i < vertex; i++)
            {
                stringBuilder.Append($"Vertex {i} [");

                foreach (var item in adjacent[i])
                {
                    stringBuilder.Append($"{item},");
                }
                stringBuilder.AppendLine("]");
            }

            return stringBuilder.ToString();
        }

    }
}
