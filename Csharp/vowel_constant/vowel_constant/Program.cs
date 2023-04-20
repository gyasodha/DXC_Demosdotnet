namespace vowel_constant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the alphabet");
            char x = Convert.ToChar(Console.ReadLine());
            if (x=='A' || x=='a' || x=='e' || x=='E' || x=='i' || x=='I' || x=='o' || x=='O' || x=='u' || x == 'U')
            {
                Console.WriteLine(x + " " + "is a vowel");
            }
            else
            {
                Console.WriteLine(x + " " + "is not a vowel");
            }
        }
    }
}