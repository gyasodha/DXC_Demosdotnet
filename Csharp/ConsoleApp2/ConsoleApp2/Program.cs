namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature in celsius");
            int c = Convert.ToInt32(Console.ReadLine());
            int f = (c * 9/5) + 32;
            Console.WriteLine(f);
        }
    }
}