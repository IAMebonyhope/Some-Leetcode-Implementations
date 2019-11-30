# -*- coding: utf-8 -*-
"""
Created on Sat Nov 30 15:18:46 2019

@author: HP
"""

class Solution(object):
    def suggestedProducts(self, products, searchWord):
        """
        :type products: List[str]
        :type searchWord: str
        :rtype: List[List[str]]
        """
        searches = []
        
        products.sort()
        
        for i in range(len(searchWord)):
            search = []
            for j in range(len(products)):
                
                if(self.isMatch(searchWord, i, products[j])):
                    stop = j+3
                    if(stop >= len(products)):
                        stop = (len(products))
                        
                    for k in range(j, stop):
                        if(self.isMatch(searchWord, i, products[k])):
                            search.append(products[k])
                    break
            searches.append(search)
                    
                    
        return searches
                    
        
    def isMatch(self, searchWord, i, product):
        if(i >= len(product)):
            return False
        
        for k in range(0, i+1):
            if(searchWord[k] != product[k]):
                return False
        return True
        