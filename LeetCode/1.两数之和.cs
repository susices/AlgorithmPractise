using System.Collections.Generic;
using System;
/*
 * @lc app=leetcode.cn id=1 lang=csharp
 *
 * [1] 两数之和
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // 蠢逼法
        for(int i = 0; i < nums.Length - 1; ++i)
        {
            for(int j = i + 1; j < nums.Length; ++j)
            {
                if(nums[i] + nums[j] == target)
                {
                    return new int[] {i, j};
                }
            }
        }
            return new int[] {};
    }
}
// @lc code=end

