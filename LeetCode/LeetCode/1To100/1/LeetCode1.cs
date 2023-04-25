using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class LeetCode1
{
    public static void Run()
    {
        int[] nums = new int[2];
        nums[0] = 3;
        nums[1] = 3;
        Console.WriteLine(TwoSum(nums, 6));
    }

    /// <summary>
    /// 瞎几把写版本
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static int[] TwoSumBad(int[] nums, int target)
    {
        List<int> numsTemp = nums.ToList();

        if (numsTemp.Contains(target) && numsTemp.Contains(0))
        {
            if (numsTemp.IndexOf(target) != numsTemp.LastIndexOf(0))
            {
                return new int[2]
                {
                    numsTemp.IndexOf(target),
                    numsTemp.LastIndexOf(0)
                };
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (numsTemp.Contains(target - nums[i]))
            {
                if (numsTemp.IndexOf(nums[i]) != numsTemp.LastIndexOf(target - nums[i]))
                {
                    return new int[2]
                    {
                        numsTemp.LastIndexOf(nums[i]),
                        numsTemp.IndexOf(target - nums[i]),
                    };
                }
            }
        }

        return null;
    }

    public static int[] TwoSumVeryBad(int[] nums, int target)
    {
        int[] result = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (target - nums[i] == nums[j])
                {
                    if (i != j)
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }
        }

        return null;
    }

    public static int[] TwoSum(int[] nums, int target)
    {
        Hashtable hs = new Hashtable();
        for (int i = 0; i < nums.Length; i++)
        {
            if (hs.Contains(nums[i]))
            {
                if (hs.ContainsKey(target - nums[i]))
                {
                    return new int[] { (int)hs[target - nums[i]], i };
                }

                hs[nums[i]] = i;
                continue;
            }
            if (hs.ContainsKey(target - nums[i]))
            {
                return new int[] { (int)hs[target - nums[i]], i };
            }

            hs.Add(nums[i], i);
        }

        return null;
    }
}