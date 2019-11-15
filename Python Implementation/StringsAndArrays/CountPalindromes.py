# -*- coding: utf-8 -*-
"""
Created on Fri Nov 15 13:03:40 2019

@author: HP

Site: Leetcode
Category: Medium
"""

class Solution(object):
    
    
    def possiblePalindromes(self, s, left, right):
        
        pals = 0
        
        if right == -1:
            right = left
        
        while (right < len(s)) and (left > -1):
            if s[left] != s[right]:
                break

            right += 1
            left -= 1
        return pals
    
    def countSubstrings(self, s):
        """
        :type s: str
        :rtype: int
        """
        palinds = 0
        
        for i in range(len(s)):
            palinds += self.possiblePalindromes(s, i, -1)
        
        for j in range(len(s)-1):
            palinds += self.possiblePalindromes(s, j, j+1)
            
        return palinds
    
    
   