namespace AlgoritmosProject.Services.Heap;

public static class FindKthLargest
{
    public static int FindKthLargestElement(int[] nums, int k)
    {
        PriorityQueue<int, int> priorityQueue = new();

        foreach (int num in nums)
        {
            priorityQueue.Enqueue(num, num);

            if (priorityQueue.Count > k)
            {
                priorityQueue.Dequeue();
            }
        }

        return priorityQueue.Peek();
    }
}
