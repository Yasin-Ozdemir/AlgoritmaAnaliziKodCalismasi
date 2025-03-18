using System;

public class MaxSubarray
{
    public static int MaxSubarray(int[] nums)
    {
        int maxSum = nums[0];
        int currentSum = nums[0];
        
        for (int i = 1; i < nums.Length; i++)
        {
            currentSum = Math.Max(nums[i], currentSum + nums[i]);
            maxSum = Math.Max(maxSum, currentSum);
        }
        
        return maxSum;
    }

   
    public static void Main(string[] args)
    {
        int[] array = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        int result = MaxSubarray(array);
        Console.WriteLine("Maximum subarray toplamı: " + result);
    }
}