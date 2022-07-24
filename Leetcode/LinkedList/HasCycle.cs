namespace Leetcode.LinkedList;

public class HasCycle
{
    public static bool Solution(ListNode head)
    {
        if (head == null) return false;

        var first = head;
        var second = head;

        while (second.next != null && second.next.next != null)
        {
            first = first.next;
            second = second.next.next;

            if (first == second) return true;

        }

        return false;
    }
}

