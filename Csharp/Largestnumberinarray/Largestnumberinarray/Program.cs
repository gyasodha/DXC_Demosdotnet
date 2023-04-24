
int[] arr = { 7, 4, 5, 100, 81, 2, 3 };
int max = arr[0];
for (int i = 0; i < 8-1; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }

}
Console.WriteLine(max);
