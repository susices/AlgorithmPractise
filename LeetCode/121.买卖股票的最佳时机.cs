/*
 * @lc app=leetcode.cn id=121 lang=csharp
 *
 * [121] 买卖股票的最佳时机
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int[] prices) {
        // 顺序寻找最大差值
        int minPrices = prices[0];
        int maxProfit = 0;
        for(int i = 0; i < prices.Length; i++)
        {
            if(prices[i] < minPrices)
            {
                minPrices = prices[i];
            }
            else if(prices[i] - minPrices > maxProfit)
            {
                maxProfit = prices[i] - minPrices;
            }
        }
        return maxProfit;
    }
}
// @lc code=end

