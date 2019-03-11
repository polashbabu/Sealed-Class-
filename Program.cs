using System;

namespace Sealed_class
{
    sealed class sesalclas
    { public int Add(int a, int b)
        {
           
            return a + b;
        }
       }
     
    class Program
    {
        static void Main(string[] args)
        {
            sesalclas ob = new sesalclas();
            ob.Add(10, 20);
            Console.WriteLine(ob.Add(10, 20));
            Console.ReadKey();
        }
    }
}
