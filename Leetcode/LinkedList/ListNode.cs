#pragma warning disable CS8618
#pragma warning disable CS8625

namespace Leetcode.LinkedList;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int x)
    {
        val = x;
        next = null;
    }

    public ListNode(int value = 0, ListNode node = null)
    {
        val = value;
        next = node;
    }
}
