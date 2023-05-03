namespace trycatchblock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welocme to try catch block");
            int a, b, c = 0 ;
            try
            {
                Console.WriteLine("Enter the first number");
                a = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                b = Convert.ToInt16(Console.ReadLine());
                c = a / b;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            
            }
            Console.WriteLine(c);
        }
    }
}