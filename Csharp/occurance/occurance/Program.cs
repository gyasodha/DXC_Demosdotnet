using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[] { 7, 7, 7, 7, 8, 8, 8, 5, 5, 5, 5, 6, 6, 6, 6 };
        int maxCount = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            int count = 0;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                }
            }

            if (count > maxCount)
            {
                maxCount = count;
            }
        }

        Console.Write("The element(s) that occur(s) most frequently in the array is/are: ");

        for (int i = 0; i < arr.Length; i++)
        {
            int count = 0;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                }
            }

            if (count == maxCount && arr[i] != int.MinValue)
            {
                Console.Write($"{arr[i]} ");
                arr[i] = int.MinValue;
            }
        }

        Console.WriteLine();
    }
}