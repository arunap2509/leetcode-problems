#pragma warning disable CS8600
#pragma warning disable CS8601
#pragma warning disable CS8603

namespace Leetcode.LinkedList;

public class ReverseLinkedList
{
    public static ListNode Solution(ListNode head)
    {
        ListNode newHead = null;

        while (head != null)
        {
            var next = head.next;
            head.next = newHead;
            newHead = head;
            head = next;
        }

        return newHead;
    }
}

