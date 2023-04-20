namespace Decision_making
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the three numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1>num3)
            {
                Console.WriteLine("first number is greater");
            }
            else if (num2 > num3)
            {
                Console.WriteLine("Second number is greater");
            }
            else
            {
                Console.WriteLine("Third number is greater");
            }
        }
    }
}