using System.Collections.Generic;
/*
 * @lc app=leetcode.cn id=169 lang=csharp
 *
 * [169] 多数元素
 */

// @lc code=start
public class Solution {
    public int MajorityElement(int[] nums) {
        // 蠢逼办法
        Dictionary<int, int> _dic = new Dictionary<int, int>();
        foreach(var item in nums)
        {
            if(_dic.ContainsKey(item))
            {
                _dic[item]++;
            }else
            {
                _dic[item] = 1;
            }
        }
        int result = 0;
        int max = 0;
        foreach(var item in _dic)
        {
            if(item.Value > max)
            {
                max = item.Value;
                result = item.Key;
            }
        }
        return result;
    }
}
// @lc code=end

