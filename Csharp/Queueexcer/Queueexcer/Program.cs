using System.Collections;
namespace Queueexcer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue  queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);   
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine("Before Removing");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            queue.Dequeue();
            Console.WriteLine(queue.Contains(3));

            Console.WriteLine("after removing");
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}