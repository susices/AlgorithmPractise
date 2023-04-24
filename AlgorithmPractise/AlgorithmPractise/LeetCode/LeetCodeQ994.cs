namespace AlgorithmPractise.LeetCode;

public class LeetCodeQ994
{
    public int OrangesRotting(int[][] grid)
    {
        List<OrangePos> badOranges = new List<OrangePos>();
        if (!HasGoodOrange(grid))
        {
            return 0;
        }
        HashSet<OrangePos> goodOranges = new HashSet<OrangePos>();
        InitOrangeData(grid, badOranges,goodOranges);
        UpdateBadOranges(badOranges, grid);
        int totalMinute = 0;
        while (badOranges.Count!=0)
        {
            for (int i = badOranges.Count-1; i >= 0; i--)
            {
                var badOrange = badOranges[i];
                TryRotting(grid, badOranges, goodOranges, badOrange.x - 1, badOrange.y);
                TryRotting(grid, badOranges, goodOranges, badOrange.x + 1, badOrange.y);
                TryRotting(grid, badOranges, goodOranges, badOrange.x, badOrange.y-1);
                TryRotting(grid, badOranges, goodOranges, badOrange.x, badOrange.y+1);
            }
            UpdateBadOranges(badOranges, grid);
            totalMinute++;
            if (!goodOranges.Any())
            {
                return totalMinute;
            }
        }
        if (goodOranges.Any())
        {
            return -1;
        }
        return totalMinute;
    }
    public struct OrangePos
    {
        public int x;
        public int y;

        public OrangePos(int X, int Y)
        {
            x = X;
            y = Y;
        }
    }
    public void TryRotting(int[][] grid,List<OrangePos> badOranges,HashSet<OrangePos> goodOranges, int x, int y)
    {
        if (x>=0 && x<grid.Length && y>=0 &&y<grid[0].Length && grid[x][y]==1)
        {
            grid[x][y] = 2;
            badOranges.Add(new OrangePos(x,y));
            goodOranges.Remove(new OrangePos(x, y));
        }
    }
    public bool IsGoodOrange(int[][] grid, int x, int y)
    {
        if (x<0 || y<0 || x>= grid.Length || y>=grid[0].Length)
        {
            return false;
        }
        return grid[x][y] == 1;
    }
    public void InitOrangeData(int[][] grid,List<OrangePos> badOranges,HashSet<OrangePos> goodOranges )
    {
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                int orangeType = grid[i][j];
                // 烂橘子
                if (orangeType==2)
                {
                    badOranges.Add(new OrangePos(i,j));
                }else if (orangeType==1)
                {
                    goodOranges.Add(new OrangePos(i, j));
                }
            }
        }
    }
    public bool HasGoodOrange(int[][] grid)
    {
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                int orangeType = grid[i][j];
                if (orangeType == 1)
                {
                    return true;
                }
            }
        }
        return false;
    }
    public void UpdateBadOranges(List<OrangePos> badOranges, int[][] grid)
    {
        for (int i = 0; i <badOranges.Count ; i++)
        {
            var badOrange = badOranges[i];
           
            if (IsGoodOrange(grid, badOrange.x-1,badOrange.y) 
                || IsGoodOrange(grid,badOrange.x+1,badOrange.y) 
                || IsGoodOrange(grid, badOrange.x,badOrange.y-1) 
                || IsGoodOrange(grid, badOrange.x,badOrange.y+1))
            {
                continue;
            }
            badOranges.RemoveAt(i);
        }
    }
}