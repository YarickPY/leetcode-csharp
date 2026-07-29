using LeetCode.Common;

namespace LeetCode
{
    public class LC0021_MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var dummy = new ListNode();
            var current = dummy;

            while (list1 != null || list2 != null)
            {
                current.next = new ListNode();
                current = current.next;

                if (list1 == null) 
                {
                    current.val = list2.val;
                    list2 = list2.next;
                    continue;
                }
                if (list2 == null)
                {
                    current.val = list1.val;
                    list1 = list1.next;
                    continue;
                }

                if (list1.val < list2.val)
                {
                    current.val = list1.val;
                    list1 = list1.next;
                }
                else
                {
                    current.val = list2.val;
                    list2 = list2.next;
                }
            }

            return dummy.next;
        }
    }
}