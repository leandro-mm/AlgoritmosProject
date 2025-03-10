namespace AlgoritmosProject.Services;

public class ListNode(int value = 0, ListNode? next = null)
{
    public int Value { get; set; } = value;
    public ListNode? Next { get; set; } = next;
}
