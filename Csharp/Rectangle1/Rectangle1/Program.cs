namespace Rectangle1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length and breadth of Rectangle");
            double l = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double perimeter = 2 * (l + b);
            Console.WriteLine(perimeter);
        }
    }
}