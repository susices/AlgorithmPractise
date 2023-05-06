using Internal;
using System;
/*
 * @lc app=leetcode.cn id=643 lang=csharp
 *
 * [643] 子数组最大平均数 I
 */

// @lc code=start
public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        // 经典滑动窗口
        double max = 0, sum = 0;
        // 定义第一个窗口
        for(int i = 0; i < k; ++i)
        {
            sum += nums[i];
        }
        max = sum;
        // 滑动
        for(int i = k; i < nums.Length; ++i)
        {
            sum += nums[i] - nums[i - k];
            max = Math.Max(max, sum);
        }
        return max / k;
    }
}
// @lc code=end

