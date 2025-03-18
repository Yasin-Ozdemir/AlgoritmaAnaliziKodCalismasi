using System;

public class InsertionSort
{
    public static int[] InsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];  // Yerleştirilecek eleman
            int j = i - 1;
            
            // Key'den büyük elemanları sağa kaydır
            while (j >= 0 && key < arr[j])
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;  // Key'i doğru pozisyona yerleştir
        }
        return arr;
    }

    // Test için örnek kullanım
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