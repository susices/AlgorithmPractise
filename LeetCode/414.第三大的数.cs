using System.Collections;
using System.Collections.Generic;
using System;
/*
 * @lc app=leetcode.cn id=414 lang=csharp
 *
 * [414] 第三大的数
 */

// @lc code=start
public class Solution {
    public int ThirdMax(int[] nums) {
        Array.Sort(nums);
        if(nums.Length >= 3)
        {
            ISet<int> _set = new HashSet<int>();
            int _count = 0;
            for(int i = nums.Length - 1; i >= 0; --i)
            {
                if(!_set.Contains(nums[i]))
                {
                    _set.Add(nums[i]);
                    if(++_count == 3)
                    {
                        return nums[i];
                    }
                }
            }
        }
        return nums[nums.Length - 1];
    }
}
// @lc code=end

