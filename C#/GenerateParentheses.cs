/**
Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
Example 1:

Input: n = 3
Output: ["((()))","(()())","(())()","()(())","()()()"]
Example 2:

Input: n = 1
Output: ["()"]
**/

public class Solution {
    List<string> res;
    int maxN = 0;
    public IList<string> GenerateParenthesis(int n) {
         res = new List<string>(); 
         maxN = n;
         backtrack(new StringBuilder() , 0, 0 ); 
         return res; 
        }
    
    private void backtrack(StringBuilder s , int openN, int closeN)
    {
        if(openN == maxN && closeN == maxN)
        {
            res.Add(s.ToString());
            return; 
        }
        if(openN < maxN)
        {
            s.Append("("); 
            backtrack(s, openN+1 , closeN); 
            s.Remove(s.Length -1,1); 
        }
        if(closeN < openN)
        {
            s.Append(")");
            backtrack(s, openN, closeN+1);
            s.Remove(s.Length -1,1);
        }
    }
}
