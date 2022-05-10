using LeetCode;

namespace AlgorithmII.Helpers
{
    public class ListNodeHelpers
    {
        public static ListNode GetSortedLinkedListWithDuplicates()
        {
            var node = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(3)
                        {
                            next = new ListNode(3)
                            {
                                next = new ListNode(4)
                                {
                                    next = new ListNode(4)
                                    {
                                        next = new ListNode(5)
                                    }
                                }
                            }
                        }
                    }
                }
            };
            return node;
        }
    }
}