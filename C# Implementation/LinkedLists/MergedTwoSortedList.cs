using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    //Site: LeetCode
    //Category: Top Interview Questions(BloomBerg)
    //Difficulty: Easy
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {

            ListNode result = new ListNode(-1);

            ListNode resultTemp = result;

            while ((l1 != null) && (l2 != null))
            {
                if (l1.val < l2.val)
                {
                    resultTemp.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    resultTemp.next = l2;
                    l2 = l2.next;
                }

                resultTemp = resultTemp.next;

            }

            if (l1 == null)
            {
                resultTemp.next = l2;
            }
            else
            {
                resultTemp.next = l1;
            }

            return result.next;
        }
    }
}
