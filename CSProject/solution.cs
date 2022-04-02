using System.Collections.Generic;
using System;
public class Solution
{
    public static void MoveZeroes(int[] nums)
    {
        int length = nums.Length;
        int pos = 0;
        for (int i = 0; i < length; i++)
        {
            if (nums[i] != 0)
            {
                nums[pos] = nums[i];
                pos++;
            }
        }
        for (; pos < length; pos++)
        {
            nums[pos] = 0;
        }
    }
}