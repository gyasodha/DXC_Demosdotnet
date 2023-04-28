using System.Collections;

namespace Arraylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add(100);
            a.Add(200);
            a.Add("Hello");
            a.Add("yashu");
            a.Add(2.5f);
            a.Add(true);

            foreach (var i in a)
            {
                Console.WriteLine(i);
            }

            a.Insert(2, "World");
            a.Insert(5, 55);

            Console.WriteLine("After Insert");
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("The count is:"  +a.Count);
            Console.WriteLine(a.Capacity);
            Console.WriteLine(a.AddRange);
            Console.WriteLine(a.Clear);
            Console.WriteLine(a.IndexOf(100));
            Console.WriteLine(a.IndexOf(200));
            
        }
    }
}   