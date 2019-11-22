# -*- coding: utf-8 -*-
"""
Created on Thu Nov 21 09:55:45 2019

@author: HP
Site: Leetcode
Category: Medium
"""

class Solution(object):
    
    def longestCommonSubsequence2(self, text1, text2):
        """
        :type text1: str
        :type text2: str
        :rtype: int
        """
        memo = {}
        
        for i in range (len(text1)+1):
            for j in range(len(text2)+1):
                memo[(i, j)] = 0
                
        for i in range (len(text1)-1, -1, -1):
            for j in range(len(text2)-1, -1, -1):
                if(text1[i] == text2[j]):
                    memo[(i,j)] = 1 + memo[(i+1,j+1)]
                else:
                    memo[(i,j)] = max(memo[(i+1,j)], memo[(i,j+1)])
            
        return memo[(0,0)]
        
    def longestCommonSubsequence(self, text1, text2):
        """
        :type text1: str
        :type text2: str
        :rtype: int
        """
        
        return self.helper(text1, text2, 0, 0, {})
    
    def helper(self, x, y, i, j, memo):
        
        if((i == len(x)) or (j == len(y))):
            return 0
        
        if((i,j) in memo):
            return memo[(i,j)]
        
        if(x[i] == y[j]):
            memo[(i,j)] = 1 + self.helper(x, y, i+1, j+1, memo)
        
        else:
            memo[(i,j)] = max(self.helper(x, y, i+1, j, memo), self.helper(x, y, i, j+1, memo))
            
        return memo[(i,j)]
        