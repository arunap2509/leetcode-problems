#pragma warning disable CS8603

namespace Leetcode.LinkedList;

public class RemoveElements
{
    public static ListNode Solution(ListNode head, int val)
    {
        if (head == null) return head;

        while (head != null && head.val == val)
        {
            head = head.next;
        }

        var resultHead = head;

        while (head != null && head.next != null)
        {
            if (head.next.val == val)
            {
                head.next = head.next.next;
            }
            else
            {
                head = head.next;
            }
        }

        return resultHead;
    }

    public static ListNode Remove(ListNode head, int val)
    {
        if (head == null)
        {
            return head;
        }

        ListNode result = new(-1);
        ListNode start = result;

        while (start.next != null)
        {
            if (start.next.val == val)
            {
                start.next = start.next.next;
                continue;
            }

            start = start.next;
        }

        return result.next;
    }
}

