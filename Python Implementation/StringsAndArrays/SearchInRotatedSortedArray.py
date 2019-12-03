# -*- coding: utf-8 -*-
"""
Created on Tue Dec  3 05:52:37 2019

@author: HP
"""

class Solution(object):
    def search(self, nums, target):
        """
        :type nums: List[int]
        :type target: int
        :rtype: int
        """
        if(len(nums) == 0):
            return -1
        
        
        low = 0
        high = len(nums)-1
        
        return self.helper(nums, target, low, high)
    
    
    def helper(self, nums, target, low, high):
        if(low == high):
            if(nums[low] == target):
                return low
            else:
                return -1
        
        if(abs(low - high) == 1):
            print("fghj")
            if(nums[low] == target):
                return low
            elif(nums[high] == target):
                return high
            else:
                return -1
            
        
        mid = int((low + high)/2)
        
        
        if(nums[mid] < nums[high]):
            if(target >= nums[mid]) and (target <= nums[high]):
                return self.helper(nums, target, mid, high)
            else:
                return self.helper(nums, target, low, mid)
            
        
        if(nums[mid] > nums[high]):
            if(target >= nums[low]) and (target <= nums[mid]):
                return self.helper(nums, target, low, mid)
            else:
                return self.helper(nums, target, mid, high)
            
            
        