// See https://aka.ms/new-console-template for more information

using AlgorithmPractise.LeetCode;




Console.WriteLine(new LeetCodeQ10().IsMatch("aabbb",".*"));
Console.WriteLine(new LeetCodeQ10().IsMatch("aabbb",".*abbb"));
Console.WriteLine(new LeetCodeQ10().IsMatch("aabbb",".*b"));
Console.WriteLine(new LeetCodeQ10().IsMatch("aabbb","a.*b"));
Console.WriteLine(new LeetCodeQ10().IsMatch("aabbb","a.*"));
Console.WriteLine(new LeetCodeQ10().IsMatch("aabbb","c*a*b*"));
Console.WriteLine(new LeetCodeQ10().IsMatch("aab","c*a*bc"));