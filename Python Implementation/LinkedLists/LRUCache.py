# -*- coding: utf-8 -*-
"""
Created on Sat Nov 30 15:15:11 2019

@author: HP
"""

class DLinkedNode():
    
    def __init__(self, key=None, value=None, next=None, prev=None):
        self.key = key
        self.value = value
        self.next = next
        self.prev = prev
        

class LRUCache(object):

    def __init__(self, capacity):
        self.count = 0
        self.capacity = capacity
        self.dict = {}
        self.head = DLinkedNode()
        self.tail = DLinkedNode()
        self.head.next = self.tail
        self.tail.prev = self.head
        

    def get(self, key):
        if not key in self.dict:
            return -1
        
        node = self.dict[key]
        
        self.move_to_tail(node)
        
        return node.value
        

    def put(self, key, value):
        
        if not key in self.dict:
            node = DLinkedNode(key=key, value=value)
            self.dict[key] = node
            self.add(node)
            self.count += 1
            self.validateCapacity()
            
        else:
            node = self.dict[key]
            node.value = value
            
            self.move_to_tail(node)
    
    
    def move_to_tail(self, node):
        self.remove(node)
        self.add(node)
    
    
    def add(self, node):
        
            prevNode = self.tail.prev
            
            prevNode.next = node
            node.prev = prevNode
            
            node.next = self.tail
            self.tail.prev = node

            
        
        
    
    def remove(self, node):
        
        prevNode = node.prev
        nextNode = node.next
        
        
        prevNode.next = nextNode
        nextNode.prev = prevNode
        
        
        
    
    def validateCapacity(self):

        if(self.count > self.capacity):
            node = self.head.next
            self.remove(node)
            del self.dict[node.key]
            self.count -= 1

        


# Your LRUCache object will be instantiated and called as such:
# obj = LRUCache(capacity)
# param_1 = obj.get(key)
# obj.put(key,value)