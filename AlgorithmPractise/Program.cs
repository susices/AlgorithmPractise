using System;

namespace AlgorithmPractise // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] grid = new int[3][]
            {
                new int[] { 2, 1, 1 },
                new int[] { 1, 1, 0 },
                new int[] { 0, 1, 1 }
            };
            var a = Algorithm.LeetCode_944_MrangesRotting(grid);
            Console.WriteLine(a);
        }
    }
}