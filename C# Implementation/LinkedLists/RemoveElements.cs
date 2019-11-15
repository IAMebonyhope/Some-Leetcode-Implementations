using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class RemoveElements
    {
        public ListNode removeElements(ListNode head, int val)
        {
            if (head == null)
            {
                return head;
            }

            ListNode node = head;

            while ((node != null) && (node.next != null))
            {
                if (node.next.val == val)
                {
                    node.next = node.next.next;
                }
                else
                {
                    node = node.next;
                }

            }



            if (head.val == val)
                return head.next;
            else
                return head;
        }
    }
}
