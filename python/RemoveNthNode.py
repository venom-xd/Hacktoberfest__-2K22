"""
Given the head of a linked list, remove the nth node from the end of the list and return its head.
Example 1:

Input: head = [1,2,3,4,5], n = 2
Output: [1,2,3,5]
Example 2:

Input: head = [1], n = 1
Output: []
Example 3:

Input: head = [1,2], n = 1
Output: [1]
"""

class Solution:
    def removeNthFromEnd(self, head: ListNode, n: int) -> ListNode:
        if head.next == None:
            return None
        tmp = head
        size = 0
        
        # find the size of the linked list
        while tmp:
            size += 1
            tmp = tmp.next
        tmp = head
        
        #if we have to remove the first node:
        if n == size: 
            return head.next
        
        for i in range(size-n-1):
            tmp = tmp.next
        tmp.next = tmp.next.next
        return head
