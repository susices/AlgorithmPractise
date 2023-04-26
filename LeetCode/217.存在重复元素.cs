/*
 * @lc app=leetcode.cn id=217 lang=csharp
 *
 * [217] 存在重复元素
 */

// @lc code=start
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        // 第一次想用双指针，但是遇到特别长的数组会超时

        // 第二次使用排序后移动框对比
        /*
        Array.Sort(nums);
        for(int i = 0; i < nums.Length - 1; ++i)
        {
            if(nums[i] == nums[i + 1])
            {
                return true;
            }
        }
        return false;
        */
        // 第三次使用哈希表
        Hashtable _hash = new Hashtable();
        foreach(var i in nums)
        {
            if(_hash.ContainsKey(i))
            {
                return true;
            }
            else
            {
                _hash.Add(i, i);
            }
        }
        return false;
    }
}
// @lc code=end

