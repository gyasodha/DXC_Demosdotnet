using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[10];
        int count = 0;

        Console.WriteLine("Enter 10 integer values:");

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Element {i}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                    break;
                }
            }
        }

        Console.WriteLine($"The number of duplicate values is {count}");
    }
}