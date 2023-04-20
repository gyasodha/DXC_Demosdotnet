namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length and breadth of the rectangle");
            int length=Convert.ToInt32(Console.ReadLine());
            int breadth=Convert.ToInt32(Console.ReadLine());
            int perimeter = 2*(length + breadth);
            Console.WriteLine(perimeter);
        }
    }
}