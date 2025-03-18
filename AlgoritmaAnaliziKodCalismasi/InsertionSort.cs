using System;

public class InsertionSort
{
    public static int[] InsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];  
            int j = i - 1;
            
        
            while (j >= 0 && key < arr[j])
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
        return arr;
    }

  
    public static void Main(string[] args)
    {
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };
        InsertionSort(array);
        Console.WriteLine("Sıralanmış dizi:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }
}
