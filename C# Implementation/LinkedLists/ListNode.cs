using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x) {
            val = x;
        }
    }

    public class DListNode
    {
        public int val;
        public DListNode next;
        public DListNode prev;
        
        public DListNode(int val)
        {
            this.val = val;
        }
    }
}
