/*
 * @lc app=leetcode.cn id=283 lang=csharp
 *
 * [283] 移动零
 */

// @lc code=start
public class Solution {
    public void MoveZeroes(int[] nums) {
        // 使用双指针
        int p1 = 0;
        int p2 = 0;
        while(p2 < nums.Length)
        {
            if(nums[p2] != 0)
            {
                if(p2 > p1)
                {
                    nums[p1] = nums[p2];
                    nums[p2] = 0;
                }
                p1++;
            }
            p2++;
        }
    }
}
// @lc code=end

