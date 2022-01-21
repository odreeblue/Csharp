using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec12_2
{
    class A
    {
        public A()
        {
            Console.WriteLine("A 생성자");
        }
        ~A()
        {
            Console.WriteLine("A 소멸자");
        }
    }
    class B:A
    {
        public B()
        {
            Console.WriteLine("B 생성자");
        }
        ~B()
        {
            Console.WriteLine("B 소멸자");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B test = new B();

        }
    }
}
