# -*- coding: utf-8 -*-
"""
Created on Thu Nov 21 13:40:40 2019

@author: HP
Site: Geek4Geeks
Category: Medium
"""

def printBoundaryView(root):
    leftTraversal(root)
    leafTraversal(root)
    rightTraversal(root.right)

def leftTraversal(root):
    if(root == None):
        return
    
    if((root.left != None) or (root.right != None)):
        print(root.data, end =" ")
    
    leftTraversal(root.left)


def rightTraversal(root):
    if(root == None):
        return
    
    rightTraversal(root.right)
    
    if((root.left != None) or (root.right != None)):
        print(root.data, end =" ")
    
    
def leafTraversal(root):
    if(root == None):
        return
    
    if((root.left == None) and (root.right == None)):
        print(root.data, end =" ")
    
    leafTraversal(root.left)
    leafTraversal(root.right)
    