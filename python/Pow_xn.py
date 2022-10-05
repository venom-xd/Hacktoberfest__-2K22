"""
Implement pow(x, n), which calculates x raised to the power n (i.e., xn).
Example 1:

Input: x = 2.00000, n = 10
Output: 1024.00000
Example 2:

Input: x = 2.10000, n = 3
Output: 9.26100
Example 3:

Input: x = 2.00000, n = -2
Output: 0.25000
Explanation: 2-2 = 1/22 = 1/4 = 0.25
"""

class Solution(object):
    def myPow(self, x, n):
        """
        :type x: float
        :type n: int
        :rtype: float
        """
        pow = 1
        if n < 0:
            n = (-n)
            x = 1/x
        while n:

            # if `n` is odd, multiply the result by `x`
            if n & 1:
                pow *= x

            # divide `n` by 2
            n = n >> 1

            # multiply `x` by itself
            x = x * x

        # return result
        return pow
