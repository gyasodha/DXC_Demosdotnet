

using System;

class Program
{
    static void Main(string[] args)
    {
        bool continueConversion = true;
        while (continueConversion)
        {
            Console.Write("Enter a temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = celsius * 9 / 5 + 32;
            Console.WriteLine("{0} Celsius is {1} Fahrenheit",celsius,fahrenheit);

            Console.Write("Do you want to convert another temperature? (y or n): ");
            string answer = Console.ReadLine();
            continueConversion = answer.ToLower() == "y";
        }
    }
}