using System.Threading;
using AlgorithmII.Helpers;
using LeetCode;

namespace AlgorithmII.Day03
{
    public class RemoveDuplicatesFromSortedListII
    {
        public static void Run()
        {
            var node = ListNodeHelpers.GetSortedLinkedListWithDuplicates();
            DeleteDuplicates(node);
        }

        public static ListNode DeleteDuplicates(ListNode head)
        {
            var sentinel = new ListNode();
            var latestNonDuplicateNode = sentinel;
            
            while (head != null)
            {
                // 1,2,3,3,3,4,4,4
                if (head.next != null && head.val == head.next.val)
                {
                    while (head.next != null && head.val == head.next.val)
                    {
                        head = head.next;
                    }

                    latestNonDuplicateNode.next = head.next;
                }
                else
                {
                    latestNonDuplicateNode.next = head;
                    latestNonDuplicateNode = latestNonDuplicateNode.next;
                }

                head = head.next;
            }

            return sentinel.next;
        }
    }
}