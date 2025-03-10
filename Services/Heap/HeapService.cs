namespace AlgoritmosProject.Services.Heap;

public static class HeapService
{
    public static void Heapify(int[] arr, int n, int i)
    {
        int largest = i;  // Initialize largest as root
        int left = 2 * i + 1;  // Left child index
        int right = 2 * i + 2; // Right child index

        // If left child is larger than root
        if (left < n && arr[left] > arr[largest])
            largest = left;

        // If right child is larger than largest so far
        if (right < n && arr[right] > arr[largest])
            largest = right;

        // If largest is not root
        if (largest != i)
        {
            (arr[i], arr[largest]) = (arr[largest], arr[i]); // Swap

            // Recursively heapify the affected sub-tree
            Heapify(arr, n, largest);
        }
    }

    private static void MinHeapify(int[] arr, int heapSize, int i, int start)
    {
        int smallest = i;
        int left = 2 * (i - start) + 1 + start;
        int right = 2 * (i - start) + 2 + start;

        if (left < start + heapSize && arr[left] < arr[smallest])
            smallest = left;

        if (right < start + heapSize && arr[right] < arr[smallest])
            smallest = right;

        if (smallest != i)
        {
            (arr[i], arr[smallest]) = (arr[smallest], arr[i]);
            MinHeapify(arr, heapSize, smallest, start);
        }
    }

    public static void BuildMinHeap(int[] arr, int start, int length)
    {
        for (int i = start + length / 2 - 1; i >= start; i--)
            MinHeapify(arr, length, i, start);
    }

    public static int GetMinimumFromTwoHeaps(int[] arr, int start1, int length1, int start2, int length2)
    {
        // Create two separate min-heaps in place
        BuildMinHeap(arr, start1, length1);
        BuildMinHeap(arr, start2, length2);

        // The root of each heap is at its respective start index
        int root1 = arr[start1];
        int root2 = arr[start2];

        // Return the minimum of the two roots
        return Math.Min(root1, root2);
    }

    public static PriorityQueue<int, int> GetPriorityMinQueueFromArray(int[] arr)
    {
        PriorityQueue<int, int> minHeap = new();

        foreach (var num in arr)
        {
            minHeap.Enqueue(num, num); // Priority = value
        }

        return minHeap;

    }
}//end class
