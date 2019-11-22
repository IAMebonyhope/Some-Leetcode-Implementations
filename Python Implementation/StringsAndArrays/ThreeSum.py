# -*- coding: utf-8 -*-
"""
Created on Mon Nov 18 10:39:36 2019

@author: HP
Site: Leetcode
Category: Medium
"""

class Solution(object):
    
    def threeSum(self, nums):
        """
        :type nums: List[int]
        :rtype: List[List[int]]
        """
        nums.sort()
        arrs = []
        
        for i in range(len(nums)):
            
            if(nums[i] > 0):
                break
                
            elif((i > 0) and (nums[i] == nums[i-1])):
                continue
                
            else:
                left = i+1
                right = len(nums) - 1
                
                while(left < right):
                    
                    if((nums[left] + nums[right]) == -(nums[i])):
                        
                        arrs.append([nums[i], nums[left], nums[right]])
                        
                        while((left < right) and (nums[left] == nums[left+1])):
                            left = left+1
                        left = left+1
                        
                        while((left < right) and (nums[right] == nums[right-1])):
                            right = right - 1
                        right = right - 1
                            
                    elif((nums[left] + nums[right]) > -(nums[i])):
                        right = right - 1
                    
                    else:
                        left = left+1
        return arrs
                            