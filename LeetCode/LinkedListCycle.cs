namespace LeetCode
{
    public class LinkedListCycle
    {
        public class ListNode
        {
            public int val;
            public ListNode? next =null;
            public ListNode(int x)
            {
                val = x;
            }
        }
        public ListNode DetectCycle(ListNode head)
        {
            HashSet<ListNode> set = new();
            ListNode current = head;
            while (current != null)
            {
                if (set.Contains(current))
                    return current;
                set.Add(current);
                current = current.next;
            }
            return null;
        }

        public ListNode DetectCycle2(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return null;
            }
            ListNode slow = head.next;
            ListNode fast = head.next.next;
            
            while (slow != fast)
            {
                if (fast.next == null || fast.next.next == null)
                    return null;

                slow = slow.next;
                fast = fast.next.next;
            }

            ListNode current = slow;

            ListNode copyHead = head;
            while (copyHead != current)
            {
                copyHead = copyHead.next;
                current = current.next;
            }

            return current;
        }
    }
}
