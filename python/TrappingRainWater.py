"""
Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining.

Example 1:

Input: height = [0,1,0,2,1,0,1,3,2,1,2,1]
Output: 6
Explanation: The above elevation map (black section) is represented by array [0,1,0,2,1,0,1,3,2,1,2,1]. In this case, 6 units of rain water (blue section) are being trapped.
Example 2:

Input: height = [4,2,0,3,2,5]
Output: 9
"""

class Solution:
    def trap(self, height: List[int]) -> int:
        result = 0
        stack = [] #(idx, height)
        stack.append((0,height[0]))
        for idx, height in enumerate(height[1:]):
            if len(stack) > 0 and stack[0][1] < height:
                while len(stack) > 1:
                    result += (stack[-2][1] - stack[-1][1]) * (idx  - stack[-2][0] )
                    stack.pop()
                stack.pop()
                stack.append((idx+1,height))
                continue
            if len(stack) > 0 and stack[-1][1] < height:
                while len(stack) > 0 and stack[-1][1] < height:
                    result += (min(height - stack[-1][1],stack[-2][1] - stack[-1][1])) * (idx  - stack[-2][0] )
                    stack.pop()
                stack.append((idx + 1, height))
            else:
                stack.append((idx + 1, height))

        return result
