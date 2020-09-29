"""
Site: Leetcode
Category: Easy
"""

class Solution(object):
    def numJewelsInStones(self, J, S):
        """
        :type J: str
        :type S: str
        :rtype: int
        """
        JSet = set(J)
        
        count = 0
        for stone in S:
            if stone in JSet:
                count +=1
        
        return count
