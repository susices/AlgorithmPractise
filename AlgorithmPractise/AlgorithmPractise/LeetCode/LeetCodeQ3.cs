namespace AlgorithmPractise.LeetCode;

public class LeetCodeQ3
{
    // 弱智版
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length==1)
        {
            return 1;
        }
        int maxLength = 0;
        HashSet<char> set = new HashSet<char>();
        // 遍历 依次做head
        for (int i = 0; i < s.Length; i++)
        {
            set.Clear();
            set.Add(s[i]);
            int curLength = 1;
            for (int j = i+1; j < s.Length; j++)
            {
                if (set.Contains(s[j]))
                {
                    break;
                }
                set.Add(s[j]);
                curLength++;
            }
            maxLength = Math.Max(curLength, maxLength);
        }
        return maxLength;
    }
    
    // 优化版
    public int LengthOfLongestSubstring2(string s)
    {
        if (s.Length==1)
        {
            return 1;
        }
        int maxLength = 0;
        int curTail = 0;
        HashSet<char> set = new HashSet<char>();
        // 遍历 依次做head
        for (int i = 0; i < s.Length; i++)
        {
            int curLength = curTail - i +1;
            set.Add(s[i]);
            // 优化一下 不用从头开始
            for (int j = curTail+1; j < s.Length; j++)
            {
                if (set.Contains(s[j]))
                {
                    set.Remove(s[i]);
                    if (curTail==i)
                    {
                        curTail++;
                    }
                    break;
                }
                set.Add(s[j]);
                curLength++;
                curTail++;
            }
            maxLength = Math.Max(curLength, maxLength);
        }
        return maxLength;
    }
}