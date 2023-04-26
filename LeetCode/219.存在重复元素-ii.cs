using System.Collections.Generic;
using System;
/*
 * @lc app=leetcode.cn id=219 lang=csharp
 *
 * [219] 存在重复元素 II
 */

// @lc code=start
public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        // 活用第二个条件，也是说这两个值的差值是k
        // 可以理解为在 i - i+k 的小范围内查询
        // 这种思想叫滑动窗口
        
        ISet<int> _set = new HashSet<int>();
        for(int i = 0; i < nums.Length; ++i)
        {
            if(i > k)
            {
                _set.Remove(nums[i - k - 1]);
            }
            if(!_set.Add(nums[i]))
            {
                return true;
            }
        }

        return false;
    }
}
// @lc code=end

