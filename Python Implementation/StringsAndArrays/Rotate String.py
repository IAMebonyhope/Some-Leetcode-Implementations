# -*- coding: utf-8 -*-
"""
Created on Fri Nov 22 08:44:24 2019

@author: HP
Site: Leetcode
Category: Easy
"""


class Solution(object):
    def rotateString(self, A, B):
        """
        :type A: str
        :type B: str
        :rtype: bool
        """
        if((A == "") and (B == "")):
            return True
        
        if((A == "") or (B == "")):
            return False
        
        if(len(A) != len(B)):
            return False
        
        A_2 = A + A
        
        for i in range(len(A_2)):
            if(A_2[i] == B[0]):
                if(self.isRestMatch(A_2, B, i+1)):
                    return True
        
        return False
    
    
    def isRestMatch(self, s1, s2, i):       
        j = 1
        
        while((i < len(s1)) and (j < len(s2))):
            if(s1[i] != s2[j]):
                return False
            i += 1
            j += 1
        
        return True
 
                