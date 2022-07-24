#pragma warning disable CS8601

namespace Leetcode.LinkedList;

public class MergeLinkedList
{
    public static ListNode Solution(ListNode list1, ListNode list2)
    {

        if (list1 == null && list2 == null)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return null;
#pragma warning restore CS8603 // Possible null reference return.
        }

        if (list1 == null)
        {
            return list2;
        }

        if (list2 == null)
        {
            return list1;
        }

        ListNode result;
        if (list1.val > list2.val)
        {
            result = new ListNode(list2.val);
            list2 = list2.next;
        }
        else
        {
            result = new ListNode(list1.val);
            list1 = list1.next;
        }

        var resultHead = result;

        while (list1 != null && list2 != null)
        {
            if (list1.val > list2.val)
            {
                result.next = new ListNode(list2.val);
                result = result.next;

                list2 = list2.next;
            }
            else
            {
                result.next = new ListNode(list1.val);
                result = result.next;

                list1 = list1.next;
            }
        }

        while (list1 != null)
        {
            result.next = new ListNode(list1.val);
            result = result.next;

            list1 = list1.next;
        }

        while (list2 != null)
        {
            result.next = new ListNode(list2.val);
            result = result.next;

            list2 = list2.next;
        }

        return resultHead;
    }

    public static ListNode MergeTwoLists(ListNode a, ListNode b)
    {
        ListNode result = new(-1);
        ListNode current = result;
        ListNode l1 = a;
        ListNode l2 = b;

        while (l1 != null && l2 != null)
        {
            if (l1.val < l2.val)
            {
                current.next = l1;
                l1 = l1.next;
            }
            else
            {
                current.next = l2;
                l2 = l2.next;
            }
            current = current.next;
        }

        if (l1 != null)
        {
            current.next = l1;
        }
        else
        {
            current.next = l2;
        }

        return result.next;
    }
}

