using System;
using System.Text;

public class LeetCode482
{
    public static void Run()
    {
        Console.WriteLine(LicenseKeyFormatting("aaaa", 2));
    }

    public static string LicenseKeyFormatting(string s, int k)
    {
        s = s.ToUpper();
        s = s.Replace("-", "");
        StringBuilder sb = new StringBuilder();
        // 可以分为几段
        int n = s.Length % k != 0 ? s.Length / k : s.Length / k - 1;

        int count = 0;
        for (int i = s.Length - 1, tempFlag = 0; i >= 0; i--)
        {
            sb.Append(s[i]);
            tempFlag++;
            if (tempFlag == k && count != n)
            {
                sb.Append('-');
                tempFlag = 0;
                count++;
            }
        }

        StringBuilder resres = new StringBuilder();
        for (int i = sb.Length - 1; i >= 0; i--)
        {
            resres.Append(sb[i]);
        }

        return resres.ToString();
    }
}