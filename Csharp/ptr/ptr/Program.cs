namespace ptr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the principal");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Rate of intreset");
            double i = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the time");
            int t = Convert.ToInt32(Console.ReadLine());
            double Si = (p * i * t)/100;
            Console.WriteLine(Si);

        }
    }
}