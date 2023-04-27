using System.Collections.Generic;
/*
 * @lc app=leetcode.cn id=448 lang=csharp
 *
 * [448] 找到所有数组中消失的数字
 */

// @lc code=start
public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        // 使用哈希
        // 想法就是利用 Contains 来判断
        List<int> _list = new List<int>();
        ISet<int> _set = new HashSet<int>();
        int len = nums.Length;
        foreach(int i in nums)
        {
            _set.Add(i);
        }
        for(int i = 1; i <= len; ++i)
        {
            if(!_set.Contains(i))
            {
                _list.Add(i);
            }
        }
        return _list;
    }
}
// @lc code=end

