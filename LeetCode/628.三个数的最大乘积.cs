using System;
/*
 * @lc app=leetcode.cn id=628 lang=csharp
 *
 * [628] 三个数的最大乘积
 */

// @lc code=start
public class Solution {
    public int MaximumProduct(int[] nums) {
        // 排序后，取最大值
        // 最后三位数的乘积
        // 如果存在负数，则取第一二位乘以最后一位（负负得正*最大的正数）
        Array.Sort(nums);
        int len = nums.Length;
        return Math.Max(nums[0] * nums[1] * nums[len - 1], nums[len - 1] * nums[len - 2] * nums[len - 3]);
    }
}
// @lc code=end

