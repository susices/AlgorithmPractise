using System;
/*
 * @lc app=leetcode.cn id=228 lang=csharp
 *
 * [228] 汇总区间
 */

// @lc code=start
public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        // 双指针
        // 无重复元素的有序数组
        List<string> _list = new List<string>();
        int point = 0;
        // 一次遍历
        while(point < nums.Length)
        {
            int index = point;
            //找到不满足条件的下标
            while(index + 1 < nums.Length && nums[index + 1] == nums[index] + 1)
            {
                index++;
            }
            // 判断是不是区间
            if(index != point)
            {
                _list.Add(nums[point] + "->" + nums[index]);
                point = index + 1;
            }
            else
            {
                _list.Add(nums[point].ToString());
                point++;
            }
        }
        return _list;
    }
}
// @lc code=end

