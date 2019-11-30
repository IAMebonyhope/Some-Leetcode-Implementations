# -*- coding: utf-8 -*-
"""
Created on Sat Nov 30 15:18:09 2019

@author: HP
"""

class Solution(object):
    def countServers(self, grid):
        """
        :type grid: List[List[int]]
        :rtype: int
        """
        totalServers = 0
        start = 0
        
        for i in range(len(grid)):
            totalServers += self.getCommunicatingX(grid, i)

        
        for j in range(len(grid[0])):
            totalServers += self.getCommunicatingY(grid, j)
  
        return totalServers
    
    
    def getCommunicatingX(self, grid, i):
        
        servers = 0
        
        for j in range(len(grid[0])):
            if(abs(grid[i][j]) == 1):
                servers += 1
        
        if(servers >= 2):
            servers = 0
            for j in range(len(grid[0])):
                if(grid[i][j] == 1):
                    servers += 1
                    grid[i][j] = -1
        else:
            servers = 0
        
        return servers
    
    
    def getCommunicatingY(self, grid, j):
        
        servers = 0
        
        for i in range(len(grid)):
            if(abs(grid[i][j]) == 1):
                servers += 1
        
        if(servers >= 2):
            servers = 0
            for i in range(len(grid)):
                if(grid[i][j] == 1):
                    servers += 1
                    grid[i][j] = -1
        else:
            servers = 0
        
        return servers
            
        