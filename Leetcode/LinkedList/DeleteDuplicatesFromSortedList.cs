namespace Leetcode.LinkedList;

public class DeleteDuplicatesFromSortedList
{
    public static ListNode Solution(ListNode head)
    {
        var resultHead = head;

        while (head != null && head.next != null)
        {
            if (head.val == head.next.val)
            {
                head.next = head.next.next;
                continue;
            }

            head = head.next;
        }

        return resultHead;
    }
}

