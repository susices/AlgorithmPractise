using System.Collections.Generic;

namespace LeetCode
{
    public class LeetCode994
    {
        // 表示四个方向
        int[] dr = new int[] { -1, 0, 1, 0 };
        int[] dc = new int[] { 0, -1, 0, 1 };

        public int OrangesRotting(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int oneNum = 0;
            Queue<int[]> queue = new Queue<int[]>();
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (grid[i][j] == 1)
                    {
                        oneNum++;
                    }
                    else if (grid[i][j] == 2)
                    {
                        queue.Enqueue(new int[] { i, j });
                    }
                }
            }
            int min = 0;
            while (oneNum > 0 && queue.Count != 0)
            {
                min++;
                int queueSize = queue.Count;
                for (int i = 0; i < queueSize; ++i)
                {
                    int[] bad = queue.Dequeue();

                    int l = bad[0];
                    int c = bad[1];
                    //传染四个方向
                    for (int d = 0; d < 4; ++d)
                    {
                        int ll = l + dr[d];
                        int cc = c + dc[d];
                     
                        if (ll >= 0 && ll < m && cc >= 0 && cc < n && grid[ll][cc] == 1)
                        {
                            grid[ll][cc] = 2;
                            oneNum--;
                            queue.Enqueue(new int[] { ll, cc });
                        }
                    }
                }
            }

            return oneNum > 0 ? -1 : min;
        }
    }
}