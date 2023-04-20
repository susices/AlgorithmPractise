namespace AlgorithmPractise // Note: actual namespace depends on the project name.
{
    internal static class Algorithm
    {
        /// <summary>
        /// 1913. 两个数对之间的最大乘积差
        /// 两个数对 (a, b) 和 (c, d) 之间的 乘积差 定义为 (a * b) - (c * d) 。
        /// 例如，(5, 6) 和(2, 7) 之间的乘积差是(5 * 6) - (2 * 7) = 16 。
        /// 给你一个整数数组 nums ，选出四个 不同的 下标 w、x、y 和 z ，使数对(nums[w], nums[x]) 和(nums[y], nums[z]) 之间的 乘积差 取到 最大值 。
        /// 返回以这种方式取得的乘积差中的最大值。
        /// </summary>
        internal static int LeetCode_1913_MaxProductDifference(int[] nums)
        {
            Array.Sort(nums);
            var length = nums.Length;
            return nums[length - 1] * nums[length - 2] - nums[0] * nums[1];
        }
        /// <summary>
        /// 在给定的 m x n 网格 grid 中，每个单元格可以有以下三个值之一：
        /// 值 0 代表空单元格；
        /// 值 1 代表新鲜橘子；
        /// 值 2 代表腐烂的橘子。
        /// 每分钟，腐烂的橘子 周围 4 个方向上相邻 的新鲜橘子都会腐烂。
        /// 
        /// 返回 直到单元格中没有新鲜橘子为止所必须经过的最小分钟数。如果不可能，返回 -1
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        internal static int LeetCode_944_MrangesRotting(int[][] grid)
        {
            var m = grid.Length;
            var n = grid[0].Length;

            int minute = 0;
            int depth = 1;
            while (true)
            {
                if (CheckAllInfected(grid, m, n))
                {
                    return minute;
                }

                var infected = false;
                for (var i = 0; i < m; i++)
                {
                    for (var j = 0; j < n; j++)
                    {
                        var state = grid[i][j];
                        if (state == 2 * depth)
                        {
                            TryInfect(grid, i + 1, j, depth, ref infected);
                            TryInfect(grid, i - 1, j, depth, ref infected);
                            TryInfect(grid, i, j + 1, depth, ref infected);
                            TryInfect(grid, i, j - 1, depth, ref infected);
                        }
                    }
                }
                if (!infected)
                {
                    return -1;
                }
                depth++;
                minute++;
            }

            bool CheckAllInfected(int[][] grid, int m, int n)
            {
                for (var i = 0; i < m; i++)
                {
                    for (var j = 0; j < n; j++)
                    {
                        if (grid[i][j] == 1)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            void TryInfect(int[][] grid, int i, int j, int depth, ref bool infected)
            {
                if (i < 0 || i >= grid.Length)
                {
                    return;
                }
                if (j < 0 || j >= grid[0].Length)
                {
                    return;
                }
                if ((grid[i][j] & 1) == 0)
                {
                    return;
                }
                grid[i][j] = (depth + 1) * 2;
                infected = true;
            }
        }
    }
}