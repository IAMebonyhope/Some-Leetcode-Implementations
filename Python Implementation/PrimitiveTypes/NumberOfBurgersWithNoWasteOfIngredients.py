# -*- coding: utf-8 -*-
"""
Created on Tue Dec  3 12:52:03 2019

@author: HP
"""

class Solution(object):
    def numOfBurgers(self, tomatoSlices, cheeseSlices):
        """
        :type tomatoSlices: int
        :type cheeseSlices: int
        :rtype: List[int]
        """
        
        """ 
        for i in range(int(math.ceil(cheeseSlices/2))+1):
            x = i
            y = cheeseSlices - i
            
            if(((4*x) + (2*y)) == tomatoSlices):
                total.append(x)
                total.append(y)
                break
            
            if(((4*y) + (2*x)) == tomatoSlices):
                total.append(y)
                total.append(x)
                break
        
        return total
        """
        j = float(tomatoSlices - (2*cheeseSlices)) / 2
        s = cheeseSlices - j

        if(j < 0) or (j != int(j)) or (s < 0):
            return []
        
        
        return [int(j), int(s)]
    
    