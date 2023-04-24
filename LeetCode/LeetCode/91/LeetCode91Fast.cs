using System;


//并没有特别快，只是内存占用小了
public class LeetCode91Fast
{
    public static void Run()
    {
        Console.WriteLine(numDecodings("2106"));
    }

    public static int numDecodings(string s)
    {
        int[] memo = new int[s.Length];
        for (int i = 0; i < memo.Length; i++)
        {
            memo[i] = -1;
        }

        return process(s, memo, 0);
    }

    public static int process(string s, int[] memo, int i)
    {
        if (i == memo.Length)
        {
            return 1;
        }

        if (s[i] == '0')
        {
            return 0;
        }

        if (memo[i] != -1)
        {
            return memo[i];
        }

        int result = -1;
        if (s[i] == '1')
        {
            result = process(s, memo, i + 1);
            if (i + 1 < s.Length)
            {
                result += process(s, memo, i + 2);
            }

            memo[i] = result;
            return result;
        }

        if (s[i] == '2')
        {
            result = process(s, memo, i + 1);
            if (i + 1 < s.Length && s[i + 1] >= '0' && s[i + 1] <= '6')
            {
                result += process(s, memo, i + 2);
            }

            memo[i] = result;
            return result;
        }

        result = process(s, memo, i + 1);
        memo[i] = result;
        return result;
    }
}