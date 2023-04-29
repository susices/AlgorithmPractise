using System;
using System.Text.RegularExpressions;
/*
 * @lc app=leetcode.cn id=268 lang=csharp
 *
 * [268] 丢失的数字
 */

// @lc code=start
public class Solution {
    public int MissingNumber(int[] nums) {
        // 0 - 数组长度 的范围，要找没有出现的数
        // 第一次尝试计数排序或者同排序的方法
        //10^4 是题目给的最大长度
        /*
        int[] bucket = new int[10001];
        foreach(var i in nums)
        {
            if(bucket[i] == 0)
            {
                bucket[i] = 1;
            }
            else
            {
                bucket[i]++;
            }
        }

        for(int i = 0; i < bucket.Length; ++i)
        {
            if(bucket[i] == 0 && i >= 0 && i <= nums.Length)
            {
                return i;
            }
        }
        return 0;
        */

        // 宫水三叶yyds！！！
        // 作差法，利用等差数列先计算[1, n]出总和
        // 再计算nums的总和 cur， 两者之间的差值就是缺的
        // 但是这个方法是针对只有一个差值的情况
        // 如果这道题出现变体，求差的数有多个则不适用

        int n = nums.Length;
        int cur = 0;
        int sum = n * (n +1) / 2;
        foreach(var i in nums)
        {
            cur += i;
        }
        return sum - cur;
        
    }
}
// @lc code=end

