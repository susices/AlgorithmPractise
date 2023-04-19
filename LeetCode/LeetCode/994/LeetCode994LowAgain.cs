using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LeetCode
{
    //runtime:92 ms
    //memory:39.3 MB
    public class LeetCode994LowAgain
    {
        public int OrangesRotting(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int oneNum = 0;
            int min = 0;
            Queue<int[]> queue = new Queue<int[]>();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 2)
                    {
                        queue.Enqueue(new int[] { i, j });
                    }

                    if (grid[i][j] == 1)
                    {
                        oneNum++;
                    }
                }
            }

            while (oneNum > 0 && queue.Count > 0)
            {
                int queueSize = queue.Count;
                for (int i = 0; i < queueSize; i++)
                {
                    int[] bad = queue.Dequeue();

                    int l = bad[0];
                    int r = bad[1];
                    // 传染左边
                    if (l - 1 >= 0 && grid[l - 1][r] == 1)
                    {
                        grid[l - 1][r] = 2;
                        queue.Enqueue(new int[] { l - 1, r });
                        oneNum--;
                    }

                    // 传染上边
                    if (r - 1 >= 0 && grid[l][r - 1] == 1)
                    {
                        grid[l][r - 1] = 2;
                        queue.Enqueue(new int[] { l, r - 1 });
                        oneNum--;
                    }

                    // 传染右边
                    if (l + 1 < grid.Length && grid[l + 1][r] == 1)
                    {
                        grid[l + 1][r] = 2;
                        queue.Enqueue(new int[] { l + 1, r });
                        oneNum--;
                    }

                    //传染下边
                    if (r + 1 < grid[l].Length && grid[l][r + 1] == 1)
                    {
                        grid[l][r + 1] = 2;
                        queue.Enqueue(new int[] { l, r + 1 });
                        oneNum--;
                    }
                }

                min++;
            }

            return oneNum > 0 ? -1 : min;
        }
    }
}