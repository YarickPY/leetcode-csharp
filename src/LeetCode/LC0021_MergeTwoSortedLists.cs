using LeetCode.Common;

namespace LeetCode
{
    public class LC0021_MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var dummy = new ListNode(0);
            var current = dummy;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }

                current = current.next;
            }

            // Appending the remaining tail of one of the lists
            current.next = list1 ?? list2;

            return dummy.next;
        }
    }
}
