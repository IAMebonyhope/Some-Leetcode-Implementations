using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class DoubleLinkedList
    {
        public DListNode Head { get; set; }

        public void insertAtHead(int val)
        {
            DListNode node = new DListNode(val);

            node.next = Head;
            node.prev = null;

            if (Head != null)
            {
                Head.prev = node;
            }

            Head = node;
        }
    }
}
