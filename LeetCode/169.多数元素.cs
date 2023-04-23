using System.Collections.Generic;
/*
 * @lc app=leetcode.cn id=169 lang=csharp
 *
 * [169] 多数元素
 */

// @lc code=start
public class Solution {
    public int MajorityElement(int[] nums) {
        /*
        // 蠢逼办法
        #region 
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
        #endregion
        */

        // 时间：O(n) 空间：O(1)
        // 我们想寻找的那个众数
        int target = 0;
        // 计数器
        int count = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (count == 0) {
                // 当计数器为 0 时，假设 nums[i] 就是众数
                target = nums[i];
                // 众数出现了一次
                count = 1;
            } else if (nums[i] == target) {
                // 如果遇到的是目标众数，计数器累加
                count++;
            } else {
                // 如果遇到的不是目标众数，计数器递减
                count--;
            }
        }
        // 此时的 count 必然大于 0，此时的 target 必然就是目标众数
        return target;
    }
}
// @lc code=end

