# -*- coding: utf-8 -*-
"""
Created on Fri Nov 22 12:05:02 2019

@author: HP
"""

"""
The read4 API is already defined for you.

    @param buf, a list of characters
    @return an integer
    def read4(buf):

# Below is an example of how the read4 API can be called.
file = File("abcdefghijk") # File is "abcdefghijk", initially file pointer (fp) points to 'a'
buf = [' '] * 4 # Create buffer with enough space to store characters
read4(buf) # read4 returns 4. Now buf = ['a','b','c','d'], fp points to 'e'
read4(buf) # read4 returns 4. Now buf = ['e','f','g','h'], fp points to 'i'
read4(buf) # read4 returns 3. Now buf = ['i','j','k',...], fp points to end of file
"""
class Solution(object):
    def read(self, buf, n):
        """
        :type buf: Destination buffer (List[str])
        :type n: Number of characters to read (int)
        :rtype: The number of actual characters read (int)
        """
        count = 0
        noOfReads = 0
        
        if((n % 4) == 0):
            noOfReads = (n // 4)
        else:
            noOfReads = (n // 4) + 1
        
        while(noOfReads > 0):
            
            tempbuf = [' '] * 4
            read4(tempbuf)
        
            for i in range(0, 4):
                if((count >= n) or (tempbuf[i] == ' ')):
                    break;
                buf[count] = tempbuf[i]
                count += 1
                
            noOfReads -= 1
        
        return count