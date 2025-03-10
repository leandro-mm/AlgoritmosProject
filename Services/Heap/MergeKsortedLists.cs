using AlgoritmosProject.Services.Tree;

namespace AlgoritmosProject.Services.Heap;

public static class MergeKsortedLists
{
    public static ListNode? MergeKListsII(ListNode[] lists)
    {
        if (lists == null || lists.Length == 0)
        {
            return null;

        }

        PriorityQueue<(int value, int index, ListNode node), int> priorityQueue = new();

        for (int i = 0; i < lists.Length; i++)
        {
            if (lists[i] is ListNode)
            {
                (int val, int i, ListNode) item = (lists[i].Value, i, lists[i]);
                priorityQueue.Enqueue(item, item.val);
            }
        }

        ListNode dummyNode = new(0);

        ListNode currentNode = dummyNode;

        while (priorityQueue.Count > 0)
        {
            (int value, int index, ListNode node) heapItem = priorityQueue.Dequeue();

            currentNode.Next = heapItem.node;

            currentNode = currentNode.Next;

            if (heapItem.node.Next is ListNode)
            {
                var nextItem = (heapItem.node.Next.Value, heapItem.index, heapItem.node.Next);
                priorityQueue.Enqueue(nextItem, nextItem.Value);
            }
        }

        return dummyNode.Next;
    }

    public static ListNode? MergeKLists(ListNode[] lists)
    {
        if (lists.Length == 0)
            return null;

        if (lists.Length == 1)
            return lists[0];

        ListNode? head = null;
        ListNode? node = null;

        while (true)
        {
            int min = int.MaxValue;
            int index = -1;

            for (int i = 0; i < lists.Length; i++)
            {
                if (lists[i] is not null && lists[i].Value < min)
                {
                    min = lists[i].Value;
                    index = i;
                }
            }

            if (index == -1)
                break;

            if (head is null)
            {
                head = new ListNode(min);
                node = head;
            }
            else
            {
                node!.Next = new ListNode(min);
                node = node.Next;
            }

            lists[index] = lists[index].Next;
        }

        return head;
    }
}
