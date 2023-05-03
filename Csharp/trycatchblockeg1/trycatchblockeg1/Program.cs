namespace trycatchblockeg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0;
            try
            {
                Console.WriteLine("Enter the first number");
                a = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter the Second number");
                b = Convert.ToInt16(Console.ReadLine());
                c = a / b;
            }
            catch (DivideByZeroException) {
                Console.WriteLine("you can not divide any number by zero");
            
            }
            catch (FormatException)
            {
                Console.WriteLine("ONLY NUMBERS are allowed");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong");
            }
            finally{
                Console.WriteLine($"The result is {c}");
                Console.WriteLine("program end");

            }
        }
    }
}