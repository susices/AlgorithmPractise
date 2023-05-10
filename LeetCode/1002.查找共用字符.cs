using Internal;
using System;
using System.Collections.Generic;
/*
 * @lc app=leetcode.cn id=1002 lang=csharp
 *
 * [1002] 查找共用字符
 */

// @lc code=start
public class Solution {
    public IList<string> CommonChars(string[] words) {
        // 思路是得出每个字符串中每个字符的出现频率
        // 最后统计所有字符串中每个字符出现频率的最小值
        List<string> _result = new List<string>();
        if(words.Length == 0)
        {
            return _result;
        }
        int[] _hash = new int[26]; // 用来统计最小频率
        for(int i = 0; i < words[0].Length; i++)
        {
            _hash[words[0][i] - 'a']++;
        }
        // 统计除第一个字符串外字符的出现频率
        for(int i = 1; i < words.Length; i++)
        {
            int[] _hashOther = new int[26];
            for(int j = 0; j < words[i].Length; j++)
            {
                _hashOther[words[i][j] - 'a']++;
            }
            // 保证最小次数
            for(int k = 0; k < 26; k++)
            {
                _hash[k] = Math.Min(_hash[k], _hashOther[k]);
            }
        }
        // 统计次数，输出
        for(int i = 0; i < 26; i++)
        {
            while(_hash[i] != 0) // 重复字符
            {
                char c = (char)(i + 'a');
                _result.Add(c.ToString());
                _hash[i]--;
            }
        }
        return _result;
    }
}
// @lc code=end

