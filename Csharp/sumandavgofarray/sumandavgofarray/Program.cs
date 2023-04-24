int[] array = new int[10];
for (int i = 0; i < 10; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
var sum = array[0] + array[1] + array[2] + array[3] + array[4] + array[5] + array[6] + array[7]+ array[8]+ array[9];
var avg = sum/10;
Console.WriteLine($"The average of numbers present in array is: {avg}");
