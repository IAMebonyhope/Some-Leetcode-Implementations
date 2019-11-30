# -*- coding: utf-8 -*-
"""
Created on Sat Nov 30 16:05:43 2019

@author: HP
"""

# Definition for singly-linked list.
# class ListNode(object):
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution(object):
    def reverseBetween(self, head, m, n):
        """
        :type head: ListNode
        :type m: int
        :type n: int
        :rtype: ListNode
        """

        prev = None
        node = head
        count = 1
        
        while((count < m) and (node != None)):
            prev = node
            node = node.next
            count += 1
        
        prevM = prev
        nodeM = node
        
        prev = None
        
        while((count <= n) and (node != None)):
            temp = node.next
            node.next = prev
            prev = node
            node = temp
            count += 1
        
        nodeM.next = node
        
        if prevM != None:
            prevM.next = prev
        else:
            head = prev
        
        return head