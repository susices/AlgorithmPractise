/*
 * @lc app=leetcode.cn id=1913 lang=csharp
 *
 * [1913] 两个数对之间的最大乘积差
 */

// @lc code=start
public class Solution {
    /// <summary>
    /// 数组顺序排序，最后两位的乘积减去前两位乘积即可
    /// </summary>
    public int MaxProductDifference(int[] nums) {
        int len = nums.Length;
        Array.Sort(nums);
        return (nums[len -1 ] * nums[len - 2]) -(nums[0] * nums[1]);
    }
}
// @lc code=end

