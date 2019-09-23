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

            ListNode resultTemp = null;
            ListNode result = null;

            while ((l1 != null) || (l2 != null))
            {

                ListNode temp = null;
                if (l1 == null)
                {
                    temp = l2;
                    l2 = l2.next;
                }
                else if (l2 == null)
                {
                    temp = l1;
                    l1 = l1.next;
                }
                else if (l1.val < l2.val)
                {
                    temp = l1;
                    l1 = l1.next;
                }
                else
                {
                    temp = l2;
                    l2 = l2.next;
                }

                if (resultTemp == null)
                {
                    resultTemp = temp;
                    result = resultTemp;
                }
                else
                {
                    resultTemp.next = temp;
                    resultTemp = resultTemp.next;
                }

            }

            return result;
        }
    }
}
