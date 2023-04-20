namespace PassorFail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Student ID");
            String sid = Console.ReadLine();
            Console.WriteLine("Enter the Student nmae");
            String sname = Console.ReadLine();
            Console.WriteLine("Enter the Student age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks1");
            double marks1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the marks2");
            double marks2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the marks3");
            double marks3 = Convert.ToDouble(Console.ReadLine());
            double total = marks1 + marks2 + marks3;
            Console.WriteLine("Your score" + " " + total);
            double percentage = total/3;
            Console.WriteLine("Your percentage" + " " + percentage);
            if (percentage >= 90 && percentage <= 99)
            {
                Console.WriteLine("Your Grade is A");
                Console.WriteLine("Your result of the exam is Pass");
            }
            else if (percentage >= 80 && percentage <= 89)
            {
                Console.WriteLine("Your Grade is B");
                Console.WriteLine("Your result of the exam is Pass");

            }
            else if (percentage >= 60 && percentage <= 79)
            {
                Console.WriteLine("Your Grade is C");
                Console.WriteLine("Your result of the exam is Pass");

            }
            else if (percentage >= 50 && percentage <= 59)
            {
                Console.WriteLine("Your Grade is D");
                Console.WriteLine("Your result of the exam is Pass");

            }
            else
            {
                Console.WriteLine("Your Grade is E");
                Console.WriteLine("Your result of the exam is Fail");
            }
        }
    }
}