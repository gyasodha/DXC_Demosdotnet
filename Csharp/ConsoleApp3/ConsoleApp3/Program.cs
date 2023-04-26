namespace OOP_Demo
{
    class Calculator
    {
        public void add()
        {
            Console.WriteLine("This is add method");
        }

        public void hlo(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        public void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public int Cube(int x)
        {
            return x * x * x;
        }

        public void Add(int a, int b = 0, int c = 0)
        {
            Console.WriteLine(a + b + c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.add();
            calc.hlo("John");
            calc.hlo("James");
            calc.Sum(20, 20);
            int res = calc.Cube(25);
            Console.WriteLine(res);
            calc.Add(10, 20, 40);
        }
    }
}