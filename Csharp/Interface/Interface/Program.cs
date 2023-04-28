namespace Interface
{

    interface MyInterface
    {
        void sum(int a, int b);

    }
    interface MyInterface2
    {
        void sub(int a, int b);
    }
    class Class1 : MyInterface, MyInterface2 {
        public void sum(int a, int b) 
        {
            Console.WriteLine(a + b);
        }
        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    
       
    }
    internal class program
    {
        static void Main(string[] args)
        {
            MyInterface obj = new Class1();
            obj.sum(10, 20);
            MyInterface2 obj1 = new Class1();
            obj1.sub(50, 10);
            
        }
    }
}