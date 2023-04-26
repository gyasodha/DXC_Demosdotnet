namespace oopsconcept
{
    class Operations
    {
        public void add (int a , int b)
        {
                Console.WriteLine (a+ b);
        }
        public int sub (int a=10,int b=20)
        {
            return a - b;
        }
        public int mul (int a,int b)
        {
            return a * b;
        }
        public void div(int a = 10, int b = 0)
        {
            Console.WriteLine(a / b);
        }
        public void md(int a , int b)
        {
            Console.WriteLine(a % b);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Operations op = new Operations();
            op.add (1, 2);
            int res = op.sub();
            Console.WriteLine (res);
            int res1 = op.mul (1, 2);
            Console.WriteLine (res1);
            op.div(10,10);
            op.md(20, 5);
        }
    }
}