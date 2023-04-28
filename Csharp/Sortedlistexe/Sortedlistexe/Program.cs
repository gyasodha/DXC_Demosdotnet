using System.Collections;
using System.Collections.Generic;


namespace Sortedlistexe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList s1= new SortedList();
            s1.Add(1, "yashu");
            s1.Add(4, "priya");
            s1.Add(3, "LALI");


            Console.WriteLine(s1.GetKey(1)); 

            foreach (var item in s1.Keys)
            {
                Console.WriteLine($"Key: {item}, Value: {s1[item]}");
            }
        }
    }
}