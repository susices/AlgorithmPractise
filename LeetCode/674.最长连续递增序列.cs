/*
 * @lc app=leetcode.cn id=674 lang=csharp
 *
 * [674] 最长连续递增序列
 */

// @lc code=start
public class Solution {
    public int FindLengthOfLCIS(int[] nums) {
        // O(n)的时间复杂度
        int sum = 1; // 因为最少长度为1
        int point = 0;
        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] > nums[i - 1])
            {
                sum = Math.Max((i - point) + 1, sum);
            }
            else if(nums[i] <= nums[i - 1])
            {
                point = i;
            }
        }
        return sum;
    }
}
// @lc code=end

