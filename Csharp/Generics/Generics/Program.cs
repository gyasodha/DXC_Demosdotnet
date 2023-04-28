using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Generics
{
    class Demo<T>
    {
        T num;
        public void SetValue(T a)
        {
            num = a;

        }
        public T getValue()
        {
            return num;
        }
    }
    class Demo1<A>
    {
        A s1;
        public void SetValue(A Y)
        {
            s1 = Y;

        }
        public A getValue()
        {
            return s1;
        }
    }

    internal class Program
    {
    static void Main(string[] args)
        {
            Demo<int> obj =new Demo<int>();
            obj.SetValue(10);
            Console.WriteLine(obj.getValue());
            Demo1<string> obj2 = new Demo1<string>();
            obj2.SetValue("abc");
            Console.WriteLine(obj2.getValue());
            
        }
    }
}