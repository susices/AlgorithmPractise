/*
 * @lc app=leetcode.cn id=1913 lang=csharp
 *
 * [2682] 找出转圈游戏输家
 */

// @lc code=start
public class Solution {
    public int[] CircularGameLosers(int n, int k) {
        bool[] _arry = new bool[n];
        int m = n;
        for(int i = 0, d = k; !_arry[i]; d += k, m--)
        {
            _arry[i] = true;
            i = (i +d) % n;
        }
        int[] _ans = new int[m];
        for(int i = 0, j = 0; i < n; i++)
        {
            if(!_arry[i])
            {
                _ans[j++] = i + 1;
            }
        }
        return _ans;
    }
}