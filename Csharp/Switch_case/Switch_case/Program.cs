using System.Diagnostics;

namespace Switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the charcter to peform the operation");
            Console.WriteLine("Enter + for addition");
            Console.WriteLine("Enter - for addition");
            Console.WriteLine("Enter * for addition");
            Console.WriteLine("Enter / for addition");
            Console.WriteLine("Enter % for addition");
            char o = Convert.ToChar(Console.ReadLine());
            switch (o)
            {
                case '+': 
                    Console.WriteLine("Addition of two numbers" + " " + (a + b));
                    break;
                case '-':
                    Console.WriteLine("Subtraction of two numbers"+ " " + (a - b));
                    break;
                case '*':
                    Console.WriteLine("Multiplication of two numbers "+ " " + (a * b));
                    break;
                case '/':
                    Console.WriteLine("Division of two numbers "+ " " + (a / b));
                    break;
                case '%':
                    Console.WriteLine("modular division of two numbers to get remainder" + " " + (a % b));
                    break;
            }
        }
    }
}