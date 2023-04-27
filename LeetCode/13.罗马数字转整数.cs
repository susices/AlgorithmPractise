/*
 * @lc app=leetcode.cn id=13 lang=csharp
 *
 * [13] 罗马数字转整数
 */

// @lc code=start
public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> _dic = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int sum = 0;
        for(int i = 0; i < s.Length; ++i)
        {
            int value = _dic[s[i]];
            if(i < s.Length - 1 && value < _dic[s[i+1]])
            {
                sum -= value;
            }
            else
            {
                sum += value;
            }
        }

        return sum;
    }
}
// @lc code=end

