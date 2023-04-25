using System;
using System.Collections.Generic;
using System.Diagnostics;

public class LeetCode91
{
    public static void Run()
    {
        Console.WriteLine(NumDecodings("2106"));
    }

    public static int NumDecodings(string s)
    {
        if (!string.IsNullOrEmpty(s) && s.StartsWith("0"))
        {
            return 0;
        }

        if (s.Length == 1)
        {
            return 1;
        }

        int[] f = new int[s.Length + 10];
        f[0] = 1;
        for (int i = 1; i <= s.Length; i++)
        {
            if (isCanDecoding(s[i - 1].ToString()))
            {
                f[i] = f[i - 1];
            }

            if (i >= 2)
            {
                if (isCanDecoding(s[i-2].ToString() + s[i - 1]))
                {
                    f[i] += f[i - 2];
                }
            }
        }


        return f[s.Length];
    }

    public static bool isCanDecoding(string s)
    {
        if (s != "0" && s.Length == 1)
        {
            return true;
        }

        if (s.Length == 2)
        {
            return s.StartsWith("1") || (s.StartsWith("2") && int.Parse(s.ToCharArray()[1].ToString()) <= 6);
        }

        return false;
    }
}