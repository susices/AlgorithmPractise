using System.Collections;
using System.Collections.Generic;
/*
 * @lc app=leetcode.cn id=136 lang=csharp
 *
 * [136] 只出现一次的数字
 */

// @lc code=start
public class Solution {
    public int SingleNumber(int[] nums) {
        // 题目要求使用线性时间复杂度的算法来解决
        // 第一次用了数组，没有考虑负数的问题，审题不认真
        // 第二次使用字典
        Dictionary<int, int> _dic = new Dictionary<int, int>();
        int _result = 0;
        foreach (int value in nums)
        {
            if(_dic.ContainsKey(value))
            {
                _dic[value]++;
            }
            else
            {
                _dic[value] = 1;
            }
        }
        foreach(int num in _dic.Keys)
        {
            if(_dic[num] == 1)
            {
                _result = num;
            }
        }

        return _result;
    }
}
// @lc code=end

