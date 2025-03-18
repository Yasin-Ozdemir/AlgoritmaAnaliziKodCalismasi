using System;

public class MaxSubarraySum
{
    public static int MaxSubarraySum(int[] arr)
    {
        return Helper(arr, 0, arr.Length - 1);
    }

    private static int Helper(int[] arr, int low, int high)
    {
        if (low == high)
        {
            return arr[low];
        }
        
        int mid = (low + high) / 2;
        
       
        int leftMax = Helper(arr, low, mid);
        int rightMax = Helper(arr, mid + 1, high);
        int crossMax = MaxCrossingSum(arr, low, mid, high);
        
        return Math.Max(Math.Max(leftMax, rightMax), crossMax);
    }

    private static int MaxCrossingSum(int[] arr, int low, int mid, int high)
    {
        
        int leftSum = int.MinValue;
        int total = 0;
        for (int i = mid; i >= low; i--)
        {
            total += arr[i];
            if (total > leftSum)
            {
                leftSum = total;
            }
        }
        
       
        int rightSum = int.MinValue;
        total = 0;
        for (int i = mid + 1; i <= high; i++)
        {
            total += arr[i];
            if (total > rightSum)
            {
                rightSum = total;
            }
        }
        
        return leftSum + rightSum;
    }

    
    public static void Main(string[] args)
    {
        int[] array = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        int result = MaxSubarraySum(array);
        Console.WriteLine("Maximum subarray toplamı: " + result);
    }
}