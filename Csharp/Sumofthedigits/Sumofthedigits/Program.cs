namespace Sumofthedigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int sum = 0;
            int ld = 0;
            int n = Convert.ToInt16(Console.ReadLine());
            while (n != 0)
            {
                ld = n % 10;
                sum = sum + ld;
                n = n / 10;
                
            }
            Console.WriteLine($"Addition of the digits is {sum}");
        }
    }
}