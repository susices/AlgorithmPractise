using System;
/*
 * @lc app=leetcode.cn id=724 lang=csharp
 *
 * [724] 寻找数组的中心下标
 */

// @lc code=start
public class Solution {
    public int PivotIndex(int[] nums) {
        // 全部元素和 = 左和 + 右和 + 中心值
        int _totalNum = nums.Sum();
        int _sum = 0;
        for(int i = 0; i < nums.Length; ++i)
        {
            // 因为要左和 = 右和
            // 所有 2 * 单侧和 + 中心值 = 总和
            if(2 * _sum + nums[i] == _totalNum)
            {
                return i;
            }
            _sum += nums[i];
        }
        return -1;
    }
}
// @lc code=end

