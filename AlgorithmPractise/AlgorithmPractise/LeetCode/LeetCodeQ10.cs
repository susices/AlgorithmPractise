namespace AlgorithmPractise.LeetCode;

public class LeetCodeQ10
{
    public bool IsMatch(string s, string p)
    {
        bool[,] dp = new bool[s.Length+1, p.Length+1];
        for (int i = 0; i < s.Length+1; i++)
        {
            if (i==0)
            {
                dp[i, 0] = true;
            }
            else
            {
                dp[i, 0] = false;
            }
        }

        for (int i = 0; i < p.Length; i++)
        {
            if (p[i]=='*')
            {
                dp[0, i+1] = dp[0, i - 1];
                continue;
            }
            dp[0, i+1] = false;
        }

        for (int y = 0; y < p.Length; y++)
        {
            for (int x = 0; x < s.Length; x++)
            {
                if (y==0)
                {
                    dp[x+1, y+1] = dp[x , y] && (p[y] == '.' || s[x] == p[y]);
                    continue;
                }

                if (p[y]=='.')
                {
                    dp[x+1, y+1] = dp[x, y];
                    continue;
                }
                
                if (p[y]!='*')
                {
                    dp[x+1, y+1] = dp[x, y] && s[x] == p[y];
                    continue;
                }

                // 当前p=*
                // 前一个为.
                if (p[y-1]=='.')
                {
                    dp[x+1, y+1] = dp[x+1,y-1]|| dp[x+1, y] || dp[x, y+1];
                    continue;
                }
                
                // 前一个为a-z    
                dp[x+1, y+1] = dp[x+1, y - 1] || dp[x+1, y] || (dp[x, y+1] && p[y - 1] == s[x]);
            }
        }
        
        return dp[s.Length,p.Length];
    }
}