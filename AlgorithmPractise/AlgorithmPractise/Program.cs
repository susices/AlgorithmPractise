// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
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

        return null;
    }
}