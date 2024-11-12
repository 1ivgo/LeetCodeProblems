using Common;

namespace Easy;

internal sealed class MergeTwoSortedLists
{
    internal ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        return GetNext(list1, list2);

        static ListNode? GetNext(ListNode? first, ListNode? second)
        {
            if(first is null && second is null)
                return null;
            if (first is null && second is not null)
                return new ListNode(second.Value, GetNext(first, second.Next));
            if (first is not null && second is null)
                return new ListNode(first.Value, GetNext(first.Next, second));

            return first!.Value < second!.Value
                ? new ListNode(first.Value, GetNext(first.Next, second))
                : new ListNode(second.Value, GetNext(first, second.Next));
        }
    }
}