using System.IO;
using System.Text.RegularExpressions;
using System.Data;
using Internal;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.Metadata;
using System.Buffers;
using System.Collections;
using System.ComponentModel;
using System;
/*
 * @lc app=leetcode.cn id=1043 lang=csharp
 *
 * [1043] 分隔数组以得到最大和
 */

// @lc code=start
public class Solution {
    public int MaxSumAfterPartitioning(int[] arr, int k) {
        // 获取数组长度
        int len = arr.Length;
        // 用来存放最大和的数组，最后一位即所需的最大的最大和
        int[] traArr = new int[len + 1];
        // i 是分割的位置
        for(int i = 1; i <= len; i++)
        {
            // 从数组最后倒叙寻找，子数组长度不超过 K，获得最大值            
            int maxValue = arr[i - 1];
            for(int j = i - 1; j >= 0 && j >= i - k; j--)
            {
                traArr[i] = Math.Max(traArr[i], traArr[j] + maxValue * (i - j));
                if( j > 0 )
                {
                    maxValue = Math.Max(maxValue, arr[j - 1]);
                }
            }
        }
        return traArr[len];
    }
}
// @lc code=end

