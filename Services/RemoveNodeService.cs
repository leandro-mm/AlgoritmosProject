
namespace AlgoritmosProject.Services;

public static class RemoveNodeService
{
    public static ListNode RemoveNthNodeFromList(ListNode head, int nth)
    {
        ListNode dummy = new ListNode(0);
        dummy.Next = head;

        ListNode slow = dummy;
        ListNode fast = dummy;

        // fast runner moves n steps first
        for (int i = 0; i < nth; i++)
        {
            fast = fast.Next;
        }

        // slow and fast move together
        while (fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next;
        }

        slow.Next = slow.Next.Next;

        return dummy.Next;
    }
}

public class ListNode(int value)
{
    public int Value { get; set; } = value;
    public ListNode? Next { get; set; } = null;
}
