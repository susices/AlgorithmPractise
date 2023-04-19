namespace AlgorithmPractise.LeetCode;

public class LeetCodeQ1
{
    /// <summary>
    /// 两层遍历 时间复杂度On2
    /// </summary>
    public int[] TwoSum1(int[] nums, int target) {
        
        for (int i = 0; i <= nums.Length-1; i++)
        {
            for (int j = 0; j <= nums.Length-1; j++)
            {
                if (i==j)
                {
                    continue;
                }

                if (nums[i] + nums[j]==target)
                {
                    return new[] { i, j };
                }
            }
        }

        return new []{-1};
    }
    
    /// <summary>
    /// 一层遍历 + 哈希表 时间复杂度On
    /// </summary>
    public int[] TwoSum2(int[] nums, int target)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        
        dic[nums[0]] = 0;
        
        for (int i = 1; i <= nums.Length-1; i++)
        {
            int value = nums[i];
            int leftValue = target - value;
            if (dic.TryGetValue(leftValue, out int index))
            {
                return new[] { index, i };
            }
            dic[value] = i;
        }

        return new []{-1};
    }
}