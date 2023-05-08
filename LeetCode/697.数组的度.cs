using System.Collections.Generic;
using System;
/*
 * @lc app=leetcode.cn id=697 lang=csharp
 *
 * [697] 数组的度
 */

// @lc code=start
public class Solution {
    public int FindShortestSubArray(int[] nums) {
        // 给三叶姐姐磕一个
        int _len = nums.Length;
        int[] _cnt = new int[50009];
        int[] _first = new int[50009], _last = new int[50009];
        Array.Fill(_first, -1);
        int max = 0;
        for(int i = 0; i < _len; i++)
        {
            int t = nums[i];
            max = Math.Max(max, ++_cnt[t]);
            if(_first[t] == -1)
            {
                _first[t] = i;
            }
            _last[t] = i;
        }
        int _ans = int.MaxValue;
        for(int i = 0; i < _len; i++)
        {
            int t = nums[i];
            if(_cnt[t] == max)
            {
                _ans = Math.Min(_ans, _last[t] - _first[t] + 1);
            }
        }
        return _ans;
    }
}
// @lc code=end

