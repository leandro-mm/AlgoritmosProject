namespace AlgoritmosProject.Services.Graph.Course
{
    public class SolutionCourse
    {
        public bool CanFinish(int numberOfCourses, int[][] prerequisites)
        {
            //[[1,0]]
            //[[1,0],[0,1]]

            if (prerequisites == null || prerequisites.Length == 0)
            {
                return true;
            }
            else
            {
                GraphCourse graph = new();

                foreach (int[] edge in prerequisites)
                {
                    graph.AddEdge(edge[0], edge[1]);
                }

                DFS depthFirstSearch = new(graph);

                depthFirstSearch.PerformDFS();

                if (depthFirstSearch.HasCycle == true)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
