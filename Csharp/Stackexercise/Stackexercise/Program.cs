using System.Collections;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(10);
            s.Push(20);
            s.Push(30);
            s.Push(40);
            s.Push(60);

            Console.WriteLine(s.Contains(30));
            

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("After Remove with Pop Method");
            Console.WriteLine($"{s.Pop()} is popped out");
            s.Pop();
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }
    }
}