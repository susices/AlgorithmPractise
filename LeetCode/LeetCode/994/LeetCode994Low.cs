using System;
using System.Diagnostics;

namespace LeetCode
{
    //runtime:96 ms
    //memory:39.2 MB
    public class LeetCode994Low
    {
        public int OrangesRotting(int[][] grid)
        {
            int min = 0;
            if (grid.Length <= 0 || grid[0].Length <= 0)
            {
                return min;
            }

            int oneNum = 0;

            int curNum = 0;
            int[][] gridTemp = new int[grid.Length][];
            for (int i = 0; i < grid.Length; i++)
            {
                if (grid[i] != null)
                {
                    gridTemp[i] = new int[grid[i].Length];
                    for (int j = 0; j < grid[i].Length; j++)
                    {
                        if (grid[i][j] == 1)
                        {
                            oneNum++;
                        }

                        gridTemp[i][j] = grid[i][j];
                    }
                }
            }

            while (oneNum != 0)
            {
                for (int i = 0; i < grid.Length; i++)
                {
                    for (int j = 0; j < grid[i].Length; j++)
                    {
                        if (grid[i][j] == 2)
                        {
                            // 传染左边
                            if (i - 1 >= 0 && grid[i - 1] != null && grid[i - 1][j] == 1)
                            {
                                gridTemp[i - 1][j] = 2;
                            }

                            // 传染上边
                            if (j - 1 >= 0 && grid[i][j - 1] == 1)
                            {
                                gridTemp[i][j - 1] = 2;
                            }

                            // 传染右边
                            if (i + 1 < grid.Length && grid[i + 1] != null && grid[i + 1][j] == 1)
                            {
                                gridTemp[i + 1][j] = 2;
                            }

                            //传染下边
                            if (j + 1 < grid[i].Length && grid[i][j + 1] == 1)
                            {
                                gridTemp[i][j + 1] = 2;
                            }
                        }
                    }
                }

                min++;

                oneNum = 0;
                for (int i = 0; i < grid.Length; i++)
                {
                    for (int j = 0; j < grid[i].Length; j++)
                    {
                        grid[i][j] = gridTemp[i][j];
                        if (grid[i][j] == 1)
                        {
                            oneNum++;
                        }
                    }
                }

                if (oneNum == curNum && oneNum != 0)
                {
                    min = -1;
                    break;
                }
                else
                {
                    curNum = oneNum;
                }
            }

            return min;
        }
    }
}