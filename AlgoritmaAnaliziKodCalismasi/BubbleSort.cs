using System;

public class BubbleSort
{
    public static int[] BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            bool swapped = false;  // Optimizasyon için swap kontrolü
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap işlemi
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped)  // Hiç swap yapılmadıysa liste sıralıdır
                break;
        }
        return arr;
    }
    }