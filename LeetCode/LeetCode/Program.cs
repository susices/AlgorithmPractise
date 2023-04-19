using System;

namespace LeetCode
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            LeetCode994 a = new LeetCode994();

            int[][] grid = new int [4][]; //表示含有三个一维数组的数组
            grid[0] = new int[] { 2 };
            grid[1] = new int[] { 1 };
            grid[2] = new int[] { 1 };
            grid[3] = new int[] { 2 };
            // grid[2] = new int[] { 0,1,2};
    
            Console.WriteLine(a.OrangesRotting(grid));
            Console.ReadKey();
        }
    }
}