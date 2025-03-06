using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosProject.Services.Graph.ConnectedComponents.UndirectedGraph
{
    public class Solution
    {
        public int CountComponents(int n, IList<List<int>> edges)
        {
            if (n == 1 && edges.Count == 0)
                return 1;
            else
            {
                Graph G = new Graph();
                foreach (var entry in edges)
                    G.AddEdge(entry[0], entry[1], 1);
                int count = 0;
                foreach (var vertex in G)
                {
                    if (vertex.GetColor() == "white")
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
            vertex.SetColor("gray");
            Queue<Vertex> q = new Queue<Vertex>();
            q.Enqueue(vertex);
            while (q.Count != 0)
            {
                Vertex currNode = q.Dequeue();
                foreach (var nbr in currNode.GetConnections())
                {
                    if (nbr.GetColor() == "white")
                    {
                        nbr.SetColor("gray");
                        q.Enqueue(nbr);
                    }
                }
                currNode.SetColor("black");
            }
        }
    }
}
