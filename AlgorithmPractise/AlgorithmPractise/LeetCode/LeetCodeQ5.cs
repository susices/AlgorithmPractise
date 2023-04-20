namespace AlgorithmPractise.LeetCode;

public class LeetCodeQ5
{
    public string LongestPalindrome(string s)
    {
        if (s.Length==1)
        {
            return s;
        }

        if (s.Length==2)
        {
            if (s[0]==s[1])
            {
                return s;
            }
            return s[0].ToString();
        }

        int maxLength = 1;
        int maxLengthHead = 0;
        bool[,] dp = new bool[s.Length, s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            dp[i, i] = true;
            if (i<s.Length-1)
            {
                dp[i, i + 1] = s[i] == s[i + 1];
                if (dp[i, i + 1] && maxLength==1)
                {
                    maxLength = 2;
                    maxLengthHead = i;
                }
            }
        }
        for (int y = 2; y < s.Length; y++)
        {
            int i = 0;
            int j = y;
            while (i<s.Length&&j<s.Length)
            {
                dp[i, j] = dp[i + 1, j - 1] && s[i] == s[j];
                if (dp[i, j]&&(j-i+1)>maxLength)
                {
                    maxLength = j - i + 1;
                    maxLengthHead = i;
                }
                i++;
                j++;
            }
        }
        return s.Substring(maxLengthHead,maxLength);
    }
}