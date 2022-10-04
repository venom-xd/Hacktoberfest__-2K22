/**
Given an integer array nums of length n and an integer target, find three integers in nums such that the sum is closest to target.

Return the sum of the three integers.

You may assume that each input would have exactly one solution.

 

Example 1:

Input: nums = [-1,2,1,-4], target = 1
Output: 2
Explanation: The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).
Example 2:

Input: nums = [0,0,0], target = 1
Output: 0
Explanation: The sum that is closest to the target is 0. (0 + 0 + 0 = 0).
**/

public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        var closet = 3_000; //maximally the closet is 3 times of element max value.
        Array.Sort(nums);
        for (var i = 0; i <= nums.Length - 3; i++) {
            var left = i + 1;
            var right = nums.Length - 1;
            while (left < right) {
                var value = nums[i] + nums[left] + nums[right];
                if (Closer(value))  closet = value;
                if (value == target) return target;
                if (value > target) right--;
                else left++;
            }
        }
        
        return closet;
        
        bool Closer(int value) => Math.Abs(value - target) <= Math.Abs(closet - target);
    }
}
