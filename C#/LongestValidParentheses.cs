/**
Description
Given a string containing just the characters '(' and ')', find the length of the longest valid (well-formed) parentheses substring.
**/
/**
Example 1:

Input: s = "(()"
Output: 2
Explanation: The longest valid parentheses substring is "()".
Example 2:

Input: s = ")()())"
Output: 4
Explanation: The longest valid parentheses substring is "()()".
Example 3:

Input: s = ""
Output: 0
**/

public class Solution 
{
    public int LongestValidParentheses(string s) 
    {
        var n = s.Length;
        
        if (n == 0) return 0;
        
        var dp = new int[n];
        for (int i = 1; i < n; i++)
        {
            if (s[i] == ')')
            {
                var leftIndex = i - 1 - dp[i-1];

                if (leftIndex >= 0 && s[leftIndex] == '(')
                {
                    // ()()(()) => solved (())
                    dp[i] = dp[i-1]+2;
                    if (leftIndex - 1 > 0)
                    {
                        // solved ()()
                        dp[i] += dp[leftIndex-1];
                    }
                }
            }
        }

        return dp.Max();
    }
}
